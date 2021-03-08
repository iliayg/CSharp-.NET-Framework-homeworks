using System;
using System.Windows.Forms;

namespace TrueFalse
{
	public partial class Form1 : Form
	{
		private TrueFalse database;

		public Form1 ()
		{
			InitializeComponent();
		}

		private void toolStripMenuItemExit_Click (object sender, EventArgs e)
		{
			Close();
		}

		private void toolStripMenuItemNew_Click (object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				database = new TrueFalse(saveFileDialog.FileName);
				database.Add("Земля круглая?", true);
				database.Save();

				nudNumber.Maximum = 1;
				nudNumber.Minimum = 1;
				nudNumber.Value = 1;
			}
		}

		private void toolStripMenuItemOpen_Click (object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				database = new TrueFalse(openFileDialog.FileName);
				database.Load();
				nudNumber.Maximum = database.Count;
				nudNumber.Minimum = 1;
				nudNumber.Value = 1;
			}
		}

		private void toolStripMenuItemSave_Click (object sender, EventArgs e)
		{
			database.Save();
		}

		private void nudNumber_ValueChanged (object sender, EventArgs e)
		{
			tbQuestion.Text = database[ (int)nudNumber.Value - 1 ].Text;
			cbTrue.Checked = database[ (int)nudNumber.Value - 1 ].TrueFalse;
		}

		private void btnAdd_Click (object sender, EventArgs e)
		{
			if (database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			database.Add((database.Count + 1).ToString(), true);
			nudNumber.Maximum = database.Count;
			nudNumber.Value = database.Count;
		}

		private void btnDelete_Click (object sender, EventArgs e)
		{
			database.Remove((int)nudNumber.Value - 1);
			nudNumber.Maximum--;
		}

		private void btnSave_Click (object sender, EventArgs e)
		{
			database[ (int)nudNumber.Value - 1 ].Text = tbQuestion.Text;
			database[ (int)nudNumber.Value - 1 ].TrueFalse = cbTrue.Checked;
		}
	}
}