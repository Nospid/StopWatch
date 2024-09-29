using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
	public partial class Form1 : Form
	{
		private int secondsElapsed; // Variable to store elapsed time in seconds
		public Form1()
		{
			InitializeComponent();
			secondsElapsed = 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		private void button3_Click(object sender, EventArgs e)
		{

			timer1.Stop(); // Stop the timer
			secondsElapsed = 0; // Reset elapsed time to zero
			labelTime.Text = "00:00:00"; // Reset the label to 00:00:00
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			secondsElapsed++; // Increment the elapsed time by one second
			TimeSpan time = TimeSpan.FromSeconds(secondsElapsed); // Convert seconds to TimeSpan
			labelTime.Text = time.ToString(@"hh\:mm\:ss"); // Update label with formatted time (hours:minutes:seconds)
		}
	}
}
