// Используя Windows Forms, разработать игру «Угадай число». 
// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
// Компьютер говорит, больше или меньше загаданное число введенного.  
// a) Для ввода данных от человека используется элемент TextBox;
// б) **Реализовать отдельную форму c TextBox для ввода числа.
//=================================================================================

using System;
using System.Windows.Forms;

namespace web7_2_
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main ()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}