// ��������� Windows Forms, ����������� ���� ������� �����. 
// ��������� ���������� ����� �� 1 �� 100, � ������� �������� ��� ������� �� ����������� ����� �������. 
// ��������� �������, ������ ��� ������ ���������� ����� ����������.  
// a) ��� ����� ������ �� �������� ������������ ������� TextBox;
// �) **����������� ��������� ����� c TextBox ��� ����� �����.
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