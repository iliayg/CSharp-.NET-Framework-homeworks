using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace web7_2_
{
	public partial class Form1 : Form
	{
		int answer;
		int count = 0;
		int dialogResult;
		public Form1 ()
		{
			InitializeComponent();
			Random rnd = new Random();
			answer = rnd.Next(1, 100);
		}

		private void button1_Click (object sender, EventArgs e)
		{
			count++;
			if (count < 6)
			{
				label2.Text = textBox1.Text;
				if (Int32.TryParse(label2.Text, out dialogResult))
					Compare(answer, dialogResult);
			}
			else
				MessageBox.Show($"Вы проиграли! Верный ответ = {answer}",
"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			textBox1.Clear();
		}

		private void Compare (int answer, int dialogResult)
		{
			if (answer < dialogResult)
				MessageBox.Show($"Не верно! Нужно меньшее число!",
				"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (answer > dialogResult)
				MessageBox.Show($"Не верно! Нужно большее число!",
					"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (answer == dialogResult)
				MessageBox.Show($"Поздравляю! Верный ответ = {answer}",
	"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			label2.Text = "0";
		}

		private void toolStripMenuItem1_Click (object sender, EventArgs e)
		{
			Form2 newMDIChild = new Form2();
			// Set the parent form of the child window.  
			newMDIChild.MdiParent = this;
			// Display the new form.  
			newMDIChild.Show();
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
		}
	}
}