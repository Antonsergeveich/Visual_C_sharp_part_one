using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Photo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//Настройка компонентов
			radioButton1.Checked = true;
			button1.Enabled = false;
		}
		//Щелчёк по кнопке OK
		private void button1_Click(object sender, EventArgs e)
		{
			double price = 0; //цена
			int n;            //количество фотографий
			double sum;       //сумма
			if (radioButton1.Checked) price = Convert.ToInt32(textBox2.Text); ;
			if (radioButton2.Checked) price = Convert.ToInt32(textBox3.Text); ;
			if (radioButton3.Checked) price = Convert.ToInt32(textBox4.Text); ;
			n = Convert.ToInt32(textBox1.Text);
			sum = n * price;
			label3.Text = "Price: " + price.ToString("C") +
				"\nCount: " + n.ToString() + " pieces\n" +
				"Order sum: " + sum.ToString("C");
		}
		//В поле Count можно ввести только целое число
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
			if (Char.IsControl(e.KeyChar))
			{
				if (e.KeyChar == (char)Keys.Enter)
				{
					//нажата клавиша Enter
					button1.Focus();
				}
				return;
			}
			//Остальные символы запрещены
			e.Handled = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text.Length == 0)
			{
				button1.Enabled = false;
			}
			else
			{
				button1.Enabled = true;
			}
		}
		//щелчок на radioButton
		private void radioButton1_Click(object sender, EventArgs e)
		{
			//Установить курсор в поле количество
			textBox1.Focus();
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				if (sender.Equals(textBox1))
				{
					button1.Focus();
				}
				return;
			}
		}
	}
}
