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
			if(radioButton2.Checked)
			{
				price = 10;
			}
			if(radioButton3.Checked)
			{
				price = 15.5;
			}
			n = Convert.ToInt32(textBox1.Text);
			sum = n * price;
			label2.Text = "Price: " + price.ToString("C") + 
				"\nCount: " + n.ToString() + "pieces\n" +
				"Order sum: " + sum.ToString("C");
		}
	}
}
