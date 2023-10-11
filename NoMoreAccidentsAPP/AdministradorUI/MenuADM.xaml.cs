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

namespace NoMoreAccidentsAPP.AdministradorUI
{
    /// <summary>
    /// Lógica de interacción para MenuADM.xaml
    /// </summary>
    public partial class MenuADM : Window
    {
        public MenuADM()
        {
            InitializeComponent();
        }

        private void btnAgregarAsesoria_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregarAsesoria_Copy2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregarAsesoria_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregarAsesoria_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, RoutedEventArgs e)
        {
            Historial HistorialWindow = new Historial();
            HistorialWindow.ShowDialog();
        }

        private void btnAsesoria_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalendario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnListaClientes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
