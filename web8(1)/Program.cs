//1. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок 
//(не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//=================================================================================

using System;
using System.Windows.Forms;

namespace TrueFalse
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