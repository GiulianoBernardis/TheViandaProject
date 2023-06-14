using MahApps.Metro.Controls;
using System;
using System.Windows;
using TheViandaProject.Controladores;
using TheViandaProject.Modelos;

namespace TheViandaProject.Vistas.Insumos
{
    /// <summary>
    /// Lógica de interacción para EditorInsumo.xaml
    /// </summary>
    public partial class EditorInsumo : MetroWindow
    {
        private Insumo modelo;
        private bool Editando;
        private InsumoController insumoController;
        public EditorInsumo()
        {
            InitializeComponent();

            modelo = new Insumo();
            DataContext = modelo;
            Editando = false;
            insumoController = new InsumoController();
        }

        public EditorInsumo(Insumo insumo)
        {
            InitializeComponent();

            modelo = insumo;
            DataContext = modelo;
            Editando = true;
            insumoController = new InsumoController();
        }

        private void Guardar(object sender, RoutedEventArgs e)
        {
            if (Editando)
            {
                var res = insumoController.Modificar(modelo);
                if (res.HayError)
                {
                    MessageBox.Show("Error", res.MensajeError);
                }
                else
                {
                    MessageBox.Show("Se ha editado el insumo con exito");
                    Close();
                }
            }
            else
            {
                var res = insumoController.Registrar(modelo);
                if (res.HayError)
                {
                    MessageBox.Show("Error", res.MensajeError);
                }
                else
                {
                    MessageBox.Show("Se ha registrado el insumo con exito");
                    Close();
                }
            }
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
