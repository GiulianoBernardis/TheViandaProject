using MahApps.Metro.Controls;
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
using TheViandaProject.Controladores;
using TheViandaProject.Modelos;
using TheViandaProject_v2.Controladores;

namespace TheViandaProject.Vistas.Insumos
{
    /// <summary>
    /// Lógica de interacción para AdministradorInsumos.xaml
    /// </summary>
    public partial class AdministradorInsumos : MetroWindow
    {
        private InsumoController insumoController;

        public AdministradorInsumos()
        {
            InitializeComponent();

            insumoController = new InsumoController();
            ActualizarDatagrid();
        }

        private void ActualizarDatagrid()
        {
            dtgInsumos.ItemsSource = null;
            dtgInsumos.ItemsSource = insumoController.ObtenerTodos();
        }

        private void NuevoInsumo(object sender, RoutedEventArgs e)
        {
            EditorInsumo editor = new EditorInsumo();
            editor.ShowDialog();
            ActualizarDatagrid();
        }

        private void EditarInsumo(object sender, RoutedEventArgs e)
        {
            if(dtgInsumos.SelectedItem != null)
            {
                var seleccionado = dtgInsumos.SelectedItem as Insumo;
                EditorInsumo editor = new EditorInsumo(seleccionado);
                editor.ShowDialog();
                ActualizarDatagrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento a editar");
            }
            
        }

        private void Habilitar(object sender, RoutedEventArgs e)
        {
            if (dtgInsumos.SelectedItem != null)
            {
                var seleccionado = dtgInsumos.SelectedItem as MateriaPrima;
                insumoController.CambiarEstado(seleccionado.Id, false);
                ActualizarDatagrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para habilitar");
            }
        }

        private void Deshabilitar(object sender, RoutedEventArgs e)
        {
            if (dtgInsumos.SelectedItem != null)
            {
                var seleccionado = dtgInsumos.SelectedItem as MateriaPrima;
                insumoController.CambiarEstado(seleccionado.Id, true);
                ActualizarDatagrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para deshabilitar");
            }
        }
    }
}
