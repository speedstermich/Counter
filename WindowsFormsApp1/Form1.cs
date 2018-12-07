using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int counter1 = 0, counter2 = 0;

		private void minus1_Click(object sender, EventArgs e)
		{
			counter1 -= 50;
			score1.Text = counter1 + "";
		}

		private void add2_Click(object sender, EventArgs e)
		{
			counter2 += 100;
			score2.Text = counter2 + "";
		}

		private void minus2_Click(object sender, EventArgs e)
		{
			counter2 -= 50;
			score2.Text = counter2 + "";
		}

		private void reset_Click(object sender, EventArgs e)
		{
			counter1 = 0;
			counter2 = counter1;
			score2.Text = counter2 + "";
			score1.Text = counter1 + "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			this.Hide();
			form2.Show();
		}

		private void button502_Click(object sender, EventArgs e)
		{
			counter1 += 50;
			score1.Text = counter1 + "";
		}

		private void button50_Click(object sender, EventArgs e)
		{
			counter2 += 50;
			score2.Text = counter2 + "";
		}

		private void add1_Click(object sender, EventArgs e)
		{
			counter1 += 100;
			score1.Text = counter1 + "";
		}
	}
}
