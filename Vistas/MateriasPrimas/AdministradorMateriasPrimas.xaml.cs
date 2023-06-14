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
using TheViandaProject.Vistas.Insumos;
using TheViandaProject_v2.Controladores;

namespace TheViandaProject.Vistas.MateriasPrimas
{
    /// <summary>
    /// Lógica de interacción para AdministradorMateriasPrimas.xaml
    /// </summary>
    public partial class AdministradorMateriasPrimas : MetroWindow
    {
        private MateriaPrimaController materiaPrimaController;
        public AdministradorMateriasPrimas()
        {
            InitializeComponent();
            materiaPrimaController= new MateriaPrimaController();
            ActualizarDatagrid();
        }

        private void ActualizarDatagrid()
        {
            dtgMateriasPrimas.ItemsSource = null;
            dtgMateriasPrimas.ItemsSource = materiaPrimaController.ObtenerTodos();
        }

        private void NuevaMateriaPrima(object sender, RoutedEventArgs e)
        {
            EditorMateriaPrima editor = new EditorMateriaPrima();
            editor.ShowDialog();
            ActualizarDatagrid();
        }

        private void EditarMateriaPrima(object sender, RoutedEventArgs e)
        {
            if (dtgMateriasPrimas.SelectedItem != null)
            {
                var seleccionado = dtgMateriasPrimas.SelectedItem as MateriaPrima;
                EditorMateriaPrima editor = new EditorMateriaPrima(seleccionado);
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
            if (dtgMateriasPrimas.SelectedItem != null)
            {
                var seleccionado = dtgMateriasPrimas.SelectedItem as MateriaPrima;
                materiaPrimaController.CambiarEstado(seleccionado.Id, false);
                ActualizarDatagrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para habilitar");
            }
        }

        private void Deshabilitar(object sender, RoutedEventArgs e)
        {
            if (dtgMateriasPrimas.SelectedItem != null)
            {
                var seleccionado = dtgMateriasPrimas.SelectedItem as MateriaPrima;
                materiaPrimaController.CambiarEstado(seleccionado.Id, true);
                ActualizarDatagrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para deshabilitar");
            }
        }
    }
}
