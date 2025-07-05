using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CallTrackerApp
{
	public partial class MainForm : Form
	{
		private Dictionary<string, int> callCounts = new Dictionary<string, int>();
		private DateTime currentDate;

		public MainForm()
		{
			InitializeComponent();
			InitializeData();
			monthCalendar1.MaxSelectionCount = 365;
			currentDate = monthCalendar1.SelectionStart.Date;
			UpdateLabels();
			dtpStartDate.Value = DateTime.Today;
			dtpEndDate.Value = DateTime.Today;
			dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
			dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
		}

		private void InitializeData()
		{
			callCounts["Заказал"] = 0;
			callCounts["Думает"] = 0;
			callCounts["Отказ"] = 0;
		}

		private void UpdateLabels()
		{
			lblOrder.Text = $"Заказал: {callCounts["Заказал"]}";
			lblThinking.Text = $"Думает: {callCounts["Думает"]}";
			lblReject.Text = $"Отказ: {callCounts["Отказ"]}";
		}


		private void btnOrder_Click(object sender, EventArgs e) { callCounts["Заказал"]++; UpdateLabels(); }
		private void btnThinking_Click(object sender, EventArgs e) { callCounts["Думает"]++; UpdateLabels(); }
		private void btnReject_Click(object sender, EventArgs e) { callCounts["Отказ"]++; UpdateLabels(); }

		private string _lastUsedDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		private void btnSave_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				folderDialog.Description = "Выберите папку для сохранения данных.\nЕсли не хотите менять директорию для сохранения файла, то нажмите кнопку OK.";
				folderDialog.ShowNewFolderButton = true;
				folderDialog.SelectedPath = _lastUsedDirectory;

				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					string directoryPath = folderDialog.SelectedPath;
					_lastUsedDirectory = directoryPath;

					try
					{
						Directory.CreateDirectory(directoryPath);
						string filePath = Path.Combine(directoryPath, $"Продажи_{currentDate:yyyy-MM-dd}.txt");

						using (StreamWriter writer = new StreamWriter(filePath))
						{
							writer.WriteLine($"Дата: {currentDate:dd.MM.yyyy}");
							writer.WriteLine($"Заказал: {callCounts["Заказал"]}");
							writer.WriteLine($"Думает: {callCounts["Думает"]}");
							writer.WriteLine($"Отказ: {callCounts["Отказ"]}");
						}

						MessageBox.Show($"Данные сохранены в файл:\n{filePath}",
									  "Успех",
									  MessageBoxButtons.OK,
									  MessageBoxIcon.Information);

					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}",
									  "Ошибка",
									  MessageBoxButtons.OK,
									  MessageBoxIcon.Error);
					}
				}
			}
		}

		private void LoadDataForDate(DateTime date)
		{
			string fileName = $"Продажи_{date:yyyy-MM-dd}.txt";
			if (File.Exists(fileName))
			{
				string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
				foreach (string line in lines)
				{
					if (line.Contains("Заказал")) callCounts["Заказал"] = int.Parse(line.Split(':')[1].Trim());
					if (line.Contains("Думает")) callCounts["Думает"] = int.Parse(line.Split(':')[1].Trim());
					if (line.Contains("Отказ")) callCounts["Отказ"] = int.Parse(line.Split(':')[1].Trim());
				}
			}
			else
			{
				callCounts["Заказал"] = 0;
				callCounts["Думает"] = 0;
				callCounts["Отказ"] = 0;
			}
			UpdateLabels();
		}

		private void btnShowChart_Click(object sender, EventArgs e)
		{
			DateTime startDate = monthCalendar1.SelectionStart;
			DateTime endDate = monthCalendar1.SelectionEnd;

			if (startDate > endDate)
			{
				MessageBox.Show("Дата начала не может быть позже даты окончания",
							  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var periodData = new List<Tuple<DateTime, int, int, int>>();
			int totalDays = (int)(endDate - startDate).TotalDays + 1;

			// Собираем данные для всех дней в диапазоне (даже если файлов нет)
			for (int i = 0; i < totalDays; i++)
			{
				DateTime currentDay = startDate.AddDays(i);
				string fileName = Path.Combine(_lastUsedDirectory, $"Продажи_{currentDay:yyyy-MM-dd}.txt");

				int ordered = 0, thinking = 0, rejected = 0;

				if (File.Exists(fileName))
				{
					foreach (string line in File.ReadAllLines(fileName))
					{
						if (line.Contains("Заказал")) ordered = int.Parse(line.Split(':')[1].Trim());
						if (line.Contains("Думает")) thinking = int.Parse(line.Split(':')[1].Trim());
						if (line.Contains("Отказ")) rejected = int.Parse(line.Split(':')[1].Trim());
					}
				}

				periodData.Add(Tuple.Create(currentDay, ordered, thinking, rejected));
			}

			// Создаем и настраиваем график
			Chart chart = new Chart();
			chart.Size = new Size(pictureBox1.Width, pictureBox1.Height);

			ChartArea chartArea = new ChartArea();
			chartArea.AxisX.LabelStyle.Angle = -45;
			chartArea.AxisX.Interval = 1;
			chartArea.AxisX.LabelStyle.Format = "dd.MM";
			chartArea.AxisY.Minimum = 0;
			chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
			chart.ChartAreas.Add(chartArea);

			// Настройка серий данных
			Series seriesOrdered = new Series("Заказал")
			{
				ChartType = SeriesChartType.Spline,
				Color = Color.Green,
				IsValueShownAsLabel = true
			};

			Series seriesThinking = new Series("Думает")
			{
				ChartType = SeriesChartType.Spline,
				Color = Color.Blue,
				IsValueShownAsLabel = true
			};

			Series seriesRejected = new Series("Отказ")
			{
				ChartType = SeriesChartType.Spline,
				Color = Color.Red,
				IsValueShownAsLabel = true
			};

			// Добавляем данные для каждого дня
			foreach (var day in periodData.OrderBy(d => d.Item1))
			{
				string dateLabel = day.Item1.ToString("dd.MM");
				seriesOrdered.Points.AddXY(dateLabel, day.Item2);
				seriesThinking.Points.AddXY(dateLabel, day.Item3);
				seriesRejected.Points.AddXY(dateLabel, day.Item4);
			}

			// Добавляем серии на график
			chart.Series.Add(seriesOrdered);
			chart.Series.Add(seriesThinking);
			chart.Series.Add(seriesRejected);

			// Настраиваем легенду
			Legend legend = new Legend();
			legend.Docking = Docking.Bottom;
			chart.Legends.Add(legend);

			// Настраиваем заголовок
			Title title = new Title($"Статистика звонков с {startDate:dd.MM.yyyy} по {endDate:dd.MM.yyyy}");
			chart.Titles.Add(title);

			// Отображаем график в PictureBox
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			chart.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
			pictureBox1.Image = bmp;
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			currentDate = e.Start;

			// Синхронизируем с DateTimePicker'ами
			dtpStartDate.Value = e.Start;
			dtpEndDate.Value = e.End;

			// Обновляем информацию о диапазоне
			lblDateRange.Text = $"Выбран диапазон: {e.Start:dd.MM.yyyy} - {e.End:dd.MM.yyyy}";
		}

		private void dtpStartDate_ValueChanged(object sender, EventArgs e)
		{
			monthCalendar1.SetSelectionRange(dtpStartDate.Value, dtpEndDate.Value);
		}

		private void dtpEndDate_ValueChanged(object sender, EventArgs e)
		{
			monthCalendar1.SetSelectionRange(dtpStartDate.Value, dtpEndDate.Value);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Вы точно хотите сбросить все показатели?",
				"Подтверждение сброса",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2); 

			if (result == DialogResult.Yes)
			{
				callCounts["Заказал"] = 0;
				callCounts["Думает"] = 0;
				callCounts["Отказ"] = 0;

				UpdateLabels();

				// Опционально: сохраняем сброшенные данные
				// btnSave_Click(null, null);
			}
		}
	}
}