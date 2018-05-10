using System;
using System.Windows;
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
				FileHelper.SaveFileDialog(TxbTextFile.Text);
			}
			catch (Exception exception)
			{
				TxbTextFile.Text = "ERROR: " + exception.Message;
			}
		}

		private void Open_File(object sender, RoutedEventArgs e)
		{
			try
			{
				TxbTextFile.Text =  FileHelper.OpenFileDialog();
			}
			catch (Exception exception)
			{
				TxbTextFile.Text = "ERROR: " + exception.Message;
			}
		}
	}
}
