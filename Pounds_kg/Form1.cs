using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pounds_kg
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//Сделать кнопку Lets go недоступной
			button1.Enabled = false;
		}
		//нажатие клавиши в поле редактирования
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
			if (e.KeyChar == '.') e.KeyChar = ',';
			if (e.KeyChar == ',')
			{
				//в поле редактирования не может быть больше одной запятой и запятая
				//не может быть первым символом
				if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
				{
					e.Handled = true;
				}
				return;
			}
			if (Char.IsControl(e.KeyChar))
			{
				//<Enter>, <Backspace>, <Esc>
				if (e.KeyChar == (char)Keys.Enter)
					//установить курсор на кнопку Lets Go
					button1.Focus();
				return;
			}
			//Остальные символы запрещены
			e.Handled = true;
		}
		//текст в поле редактирования изменился
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			label2.Text = "";//Очистить поле отображения результат расчёта
			if (textBox1.Text.Length == 0)
			{
				//в поле редактирования нет данных 
				//сделать кнопку Lets Go недоступной
				button1.Enabled = false;
			}
			else
			{
				//сделать кнопку Lets Go доступной
				button1.Enabled = true;
			}
		}
		//Щелчок на кнопке Lets Go
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double funt; //вес в фунтах
				double kg;   //вес в килограммах
				funt = Convert.ToDouble(textBox1.Text);
				//1 фунт = 409,5 грамма
				kg = funt * 0.4095;
				label2.Text = funt.ToString("N") + " funt. = " + kg.ToString("N") + " kg.";
			}
			catch 
			{
				textBox1.Clear();
				textBox1.Focus();
			}
		}
	}
}
