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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		int counter1 = 0, counter2 = 0, counter3 = 0;

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

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}

		private void add3_Click(object sender, EventArgs e)
		{
			counter3 += 100;
			score3.Text = counter3 + "";
		}

		private void minus3_Click(object sender, EventArgs e)
		{
			counter3 -= 50;
			score3.Text = counter3 + "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			counter3 += 50;
			score3.Text = counter3 + "";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			counter2 += 50;
			score2.Text = counter2 + "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			counter1 += 50;
			score1.Text = counter1 + "";
		}

		private void reset_Click(object sender, EventArgs e)
		{
			counter1 = 0;
			counter2 = counter1;
			counter3 = counter2;
			score2.Text = counter2 + "";
			score1.Text = counter1 + "";
			score3.Text = counter3 + "";
		}

		private void add1_Click(object sender, EventArgs e)
		{
			counter1 += 100;
			score1.Text = counter1 + "";
		}
	}
}
