using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace web7_1_
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Сразу объявляем 2 счётчика и поле для доступа к стэку.
		/// </summary>
		int count;      //Служит в качестве контейнера с текущим значением для обмена данными с классом Stack.
		int counter;    //Счётчик нажатий на удвоитель.
		UndoRedoStack<int> ur = new UndoRedoStack<int>();
		public Form1 ()
		{
			InitializeComponent();
			lblNumber.Text = "0";
			btnCommand1.Text = "+1";
			btnCommand2.Text = "*2";
			btnReset.Text = "Reset";
			this.Text = "Удвоитель";
		}

		#region Обработка событий.
		private void btnCommand1_Click_1 (object sender, EventArgs e)
		{
			count = ur.Do(new AddIntCommand(1), count);
			lblNumber.Text = count.ToString();
			IfCount();
		}

		private void btnCommand2_Click (object sender, EventArgs e)
		{
			counter++;
			count = ur.Do(new AddIntCommand(ur.Do(new AddIntCommand(), count)), count);
			lblNumber.Text = count.ToString();
			IfCount();
		}

		#region Счётчик кнопки удвоителя.
		private void IfCount ()
		{
			if (count == 60)
			{
				MessageBox.Show($"Поздравляю! Вы выиграли!",
				"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnReset_Click_1();
			}
			else
			{
				if (counter == 3)
				{
					MessageBox.Show(@"Вы удвоили 3 раза! Попытайтесь снова!",
				"Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					btnReset_Click_1();
				}
			}
			lblNumber.Text = count.ToString();
		}
		#endregion

		private void btnReset_Click_1 (object sender, EventArgs e)
		{
			btnReset_Click_1();
			lblNumber.Text = count.ToString();
		}
		private void btnReset_Click_1 ()
		{
			count = 0;
			counter = 0;
			ur.Reset();
		}

		private void undo_Click_1 (object sender, EventArgs e)
		{
			count = ur.Undo(count);
			lblNumber.Text = count.ToString();
		}

		private void redo_Click_1 (object sender, EventArgs e)
		{
			count = ur.Redo(count);
			lblNumber.Text = count.ToString();
		}
		#endregion


		#region Класс для обмена данными и интерфейс для связи с Generic коллекцией Stack.
		public class AddIntCommand : ICommand<int>
		{
			public AddIntCommand (int value) => Value = value;
			public AddIntCommand () { }
			public int Value { get; set; }
			public int Do (int input) => input + Value;
			public int Undo (int input) => input - Value;
		}
		public interface ICommand<T>
		{
			T Do (T input);
			T Undo (T input);
		}
		#endregion


		#region Класс на основе коллекции Stack.
		public class UndoRedoStack<T>
		{
			Stack<ICommand<T>> _undo;
			Stack<ICommand<T>> _redo;
			public UndoRedoStack ()
			{
				_undo = new Stack<ICommand<T>>();
				_redo = new Stack<ICommand<T>>();
			}

			public void Reset ()    //Метод, обнуляющий содержимое UndoRedoStack.
			{
				_undo = new Stack<ICommand<T>>();
				_redo = new Stack<ICommand<T>>();
			}

			#region Реализация "погружения и добычи" данных в памяти программы.

			public T Do (ICommand<T> cmd, T input)
			{
				T output = cmd.Do(input);
				_undo.Push(cmd);
				_redo.Clear();
				return output;
			}

			public T Undo (T input)
			{
				if (_undo.Count > 0)
				{
					ICommand<T> cmd = _undo.Pop();
					T output = cmd.Undo(input);
					_redo.Push(cmd);
					return output;
				}
				else
					return input;
			}

			public T Redo (T input)
			{
				if (_redo.Count > 0)
				{
					ICommand<T> cmd = _redo.Pop();
					T output = cmd.Do(input);
					_undo.Push(cmd);
					return output;
				}
				else
					return input;
			}
			#endregion
		}
		#endregion
	}
}