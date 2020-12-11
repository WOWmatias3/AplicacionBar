using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;
using MahApps.Metro.Controls;

namespace AplicacionBar
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btn_aceptar_Click(object sender, RoutedEventArgs e)
		{
			pruebas ba = new pruebas();
			ba.ShowDialog();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			prueba2 ct = new prueba2();
			ct.ShowDialog();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			prueba3 ct = new prueba3();
			ct.ShowDialog();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			prueba4 ct = new prueba4();
			ct.ShowDialog();
		}

		private void pepito_Click(object sender, RoutedEventArgs e)
		{
			Bar ct = new Bar();
			ct.ShowDialog();
		}
	}
}
