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
using System.Windows.Threading;
using System.Threading;

namespace restaurantexxi_adminstrador
{
    /// <summary>
    /// Lógica de interacción para Generic.xaml
    /// </summary>
    public partial class Generic : MetroWindow
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, RoutedEventArgs e)
        {
            BebestibleBLL us = new BebestibleBLL();
            IngredienteBLL ig = new IngredienteBLL();
            string act = ACCION.Content.ToString();
            if (act == "Modificarbebi")
            {
                int id = Int32.Parse(lb_rut.Content.ToString());
                lb_titulo.VerticalAlignment = VerticalAlignment.Center;
                us.id_bebestible = id;
                us.Alterinhabilitado(us);
                Close();
            }
            else if (act == "Modificaring")
            {
                int id = Int32.Parse(lb_rut.Content.ToString());
                lb_titulo.VerticalAlignment = VerticalAlignment.Center;
                ig.id_ingrediente = id;
                ig.Alterinhabilitadoing(ig);
                Close();
            }
        }

        private void Btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
