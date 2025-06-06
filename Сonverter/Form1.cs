using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сonverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			button1.Enabled = false;
		}
		//Обрабатывает нажатие клавиши  в полях редактирования  Курс и Цена.
		//Сначала нужно обычным образом создать функцию обработки событися KeyPress для компонента textBox1,
		//затем - указать её в качестве обработчика это же события для компонента textBox2
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
			if (e.KeyChar == '.') e.KeyChar = ',';
			if (e.KeyChar == ',')
			{
				if ((textBox1.Text.IndexOf(',') != -1) ||
					(textBox1.Text.Length == 0))
				{
					e.Handled = true;
				}
				return;
			}
			if (Char.IsControl(e.KeyChar))
			{
				if (e.KeyChar == (char)Keys.Enter)textBox2.Focus();
			}
			else
			{
				//Клавиша <Enter> нажата в поле Цена
				button1.Focus();
				return;
			}
			//Остальные символы запрещены
			e.Handled = true;
		}


		//Изменился текст в поле редактирования textBox1 или textBox2
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			label3.Text = "";
			if ((textBox1.Text.Length == 0) ||
				(textBox2.Text.Length == 0))
				//Если какое нибудь из полей не содержит данных,
				//то сделать не доступной кнопку OK
				button1.Enabled = false;
			else
				button1.Enabled = true;
		}
		//Щелчок на кнопке OK
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			textBox1_TextChanged(sender, e);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			double usd; //цена в долларах
			double k;   //курс
			double rub; //цена в рублях
			usd = Convert.ToDouble(textBox1.Text);
			k = Convert.ToDouble(textBox2.Text);
			rub = usd * k;
			label3.Text = rub.ToString("C"); //Финансовый формат
		}
	}
}
