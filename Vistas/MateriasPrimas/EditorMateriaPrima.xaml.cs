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

namespace TheViandaProject.Vistas.MateriasPrimas
{
    /// <summary>
    /// Lógica de interacción para EditorMateriaPrima.xaml
    /// </summary>
    public partial class EditorMateriaPrima : Window
    {

        private MateriaPrima modelo;
        private bool Editando;
        private MateriaPrimaController materiaController;
        public EditorMateriaPrima()
        {
            InitializeComponent();

            modelo = new MateriaPrima();
            DataContext = modelo;
            Editando = false;
            materiaController = new MateriaPrimaController();
        }

        public EditorMateriaPrima(MateriaPrima materia)
        {
            InitializeComponent();

            modelo = materia;
            DataContext = modelo;
            Editando = true;
            materiaController = new MateriaPrimaController();
        }

        private void Guardar(object sender, RoutedEventArgs e)
        {
            if (Editando)
            {
                var res = materiaController.Modificar(modelo);
                if (res.HayError)
                {
                    MessageBox.Show("Error", res.MensajeError);
                }
                else
                {
                    MessageBox.Show("Se ha editado la materia prima con exito");
                    Close();
                }
            }
            else
            {
                var res = materiaController.Registrar(modelo);
                if (res.HayError)
                {
                    MessageBox.Show("Error", res.MensajeError);
                }
                else
                {
                    MessageBox.Show("Se ha registrado la materia prima con exito");
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
