using System;
using System.Windows.Forms;

namespace web7_2_
{
	public partial class Form2 : Form
	{
		public int answer;
		public int count = 0;
		public int dialogResult;
		public Form2 ()
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

		private void textBox1_TextChanged (object sender, EventArgs e)
		{

		}
	}

}