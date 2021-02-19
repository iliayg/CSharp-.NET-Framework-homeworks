using System;
using System.Windows.Forms;

namespace web7_2_
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent();
		}

		private void toolStripMenuItem1_Click (object sender, EventArgs e)
		{
			Form2 newMDIChild = new Form2();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
			button2.Hide();
		}
	}
}