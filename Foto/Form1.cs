using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foto
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
		//Щелчок по кнопке OK
		private void button1_Click(object sender, EventArgs e)
		{
			double price = 0; //цена
			int n;            //количество фотографий
			double sum;       //сумма
			if (radioButton1.Checked)
			{
				price = 8.50;
			}
			if (radioButton2.Checked)
			{
				price = 10;
			}
			if (radioButton3.Checked)
			{
				price = 15.5;
			}
			n = Convert.ToInt32(textBox1.Text);
			sum = n * price;
			label2.Text = "Price: " + price.ToString("C") +
				"\nCount: " + n.ToString() + "pieces\n" +
				"Order sum: " + sum.ToString("C");
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
				label2.Text = "";
			}
		}

		private void radioButton1_Click(object sender, EventArgs e)
		{
			label2.Text = "";
			//Установить курсор в поле Count
			textBox1.Focus();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
			if(Char.IsControl(e.KeyChar))
			{
				if(e.KeyChar == (char)Keys.Enter)
				{
					//Нажата клавиша Enter
					button1.Focus();
				}
				return;
			}
			//Остальные символы запрещены
			e.Handled = true;
		}
	}
}
