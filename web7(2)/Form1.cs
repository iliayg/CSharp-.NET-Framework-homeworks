using System;
using System.Windows.Forms;

namespace web7_2_
{
	public partial class Form1 : Form
	{
		int s;
		int dialogResult;
		public Form1 ()
		{
			InitializeComponent();
			Random rnd = new Random();
			s = rnd.Next(1, 9); 
		}

		private void textBox1_TextChanged (object sender, EventArgs e)
		{
			label2.Text = textBox1.Text;
				if (Int32.TryParse(textBox1.Text, out dialogResult))
				Compare(s, dialogResult);
				textBox1.Clear();		/*--> тут, я не смог реализовать так, чтоб работал
				весь диапазон от 1 до 100 */ 
		}

		private void Compare (int s, int dialogResult)
		{
			if (s == dialogResult)
				MessageBox.Show($"Поздравляю! Верный ответ = {s}",
							"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (s < dialogResult)
				MessageBox.Show($"Не верно! Нужно меньшее число!",
				"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (s > dialogResult)
				MessageBox.Show($"Не верно! Нужно большее число!",
					"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

	}
}