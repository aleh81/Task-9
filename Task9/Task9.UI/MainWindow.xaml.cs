using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;
using Task9.BLL.Helpers;

namespace Task9.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Save_File(object sender, RoutedEventArgs e)
		{
			try
			{
				FileHelper.SaveFile(TxbTextFile.Text);
			}
			catch (Exception exception)
			{
				TxbTextFile.Text = "ERROR: " + exception.Message;
			}
		}
	}
}
