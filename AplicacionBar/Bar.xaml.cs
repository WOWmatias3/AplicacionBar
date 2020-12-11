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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using BLL;
using System.Data;
using System.Timers;
using System.Windows.Threading;

namespace AplicacionBar
{
	/// <summary>
	/// Lógica de interacción para Bar.xaml
	/// </summary>
	public partial class Bar : MetroWindow
	{
		public string username = null;
		DispatcherTimer oDispatcherTimer = new DispatcherTimer();

		public Bar()
		{
			InitializeComponent();
		}

		private void lbl_user_Loaded(object sender, RoutedEventArgs e)
		{
			lbl_user.Content = username;
		}

		private void btn_volver_Click(object sender, RoutedEventArgs e)
		{
			MainWindow log = new MainWindow();
			Close();
			log.ShowDialog();
		}

		private void banner_Loaded(object sender, RoutedEventArgs e)
		{
			
			oDispatcherTimer.Interval = new TimeSpan(0,0,5);
			oDispatcherTimer.Tick += (a, b) =>
			{
				BebestibleBLL espBLL = new BebestibleBLL();
				System.Data.DataTable dt = espBLL.getbeborden_espera();
				dtg_espera.ItemsSource = dt.DefaultView;

				BebestibleBLL prepBLL = new BebestibleBLL();
				System.Data.DataTable dta = prepBLL.getbeborden_preparacion();
				dtg_preparacion.ItemsSource = dta.DefaultView;

				BebestibleBLL lisBLL = new BebestibleBLL();
				System.Data.DataTable dtg = lisBLL.getbeborden_listo();
				dtg_listo.ItemsSource = dtg.DefaultView;

			};


		}

		private void btn_play_Click(object sender, RoutedEventArgs e)
		{
			dtg_espera.Visibility = Visibility.Visible;
			dtg_preparacion.Visibility = Visibility.Visible;
			dtg_listo.Visibility = Visibility.Visible;
			oDispatcherTimer.Start();
		}

		private void btn_stop_Click(object sender, RoutedEventArgs e)
		{
			dtg_espera.Visibility = Visibility.Hidden;
			dtg_preparacion.Visibility = Visibility.Hidden;
			dtg_listo.Visibility = Visibility.Hidden;
			oDispatcherTimer.Stop();
		}
		
		private void btn_preparacion_Click(object sender, RoutedEventArgs e)
		{
			
		}

		/*private void dtg_espera_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int numero_pedido = 0;
			try
			{
				BebestibleBLL ub = new BebestibleBLL();
				DataGrid gd = (DataGrid)sender;
				DataRowView drv = gd.SelectedItem as DataRowView;

				if (drv != null)
				{
					numero_pedido = int.Parse(drv["numero_pedido"].ToString());

				}

				DataTable dte = new DataTable();
				ub.Alterinestado_espera(ub);



			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
		}*/


	}
}
