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

		private void BtnIncrement_Click(object sender, EventArgs e)
		{
			int count = Convert.ToInt16(CounterTxt.Text);
			count += 1;
			CounterTxt.Text = count.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CounterTxt.Text = "0";

			// https://social.msdn.microsoft.com/Forums/windows/en-US/a583cee6-806e-44e6-b7f2-a98067b78418/c-set-focus-on-textbox-which-event?forum=winforms
			//BtnIncrement.Focus();
			BtnIncrement.Select();

			// To make the window unresizable
			// https://stackoverflow.com/questions/7970262/disable-resizing-of-a-windows-form
			this.FormBorderStyle = FormBorderStyle.FixedSingle;

			// To make the window center on the screen
			// https://stackoverflow.com/questions/4601827/how-do-i-center-a-window-onscreen-in-c
			this.CenterToScreen();
		}
	}
}
