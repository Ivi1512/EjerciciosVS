using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Ejemplo4.Views
{
    /// <summary>
    /// Lógica de interacción para StudentTableView.xaml
    /// </summary>
    public partial class StudentTableView : UserControl, INotifyPropertyChanged
    {
        

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private bool editarActivado { set; get; }

        public bool EditarActivado
        {
            get { return editarActivado; }
            set
            {
                editarActivado = value;
                OnPropertyChanged(nameof(EditarActivado));
            }
        }


        private bool editarNotasActivado { set; get; }

        public bool EditarNotasActivado
        {
            get { return editarNotasActivado; }
            set
            {
                editarNotasActivado = value;
                OnPropertyChanged(nameof(EditarNotasActivado));
            }
        }


        private bool cambiarEstudiante { set; get; }

        public bool CambiarEstudiante
        {
            get { return cambiarEstudiante; }
            set
            {
                cambiarEstudiante = value;
                OnPropertyChanged(nameof(CambiarEstudiante));
            }
        }


        private void studentListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            E01MostrarEstudiante();
            


        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            E02EditarEstudiante();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            E01MostrarEstudiante();
            EditarActivado = false;

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btCalificaciones_Click(object sender, RoutedEventArgs e)
        {
            E03MostrarNotas();

        }

        private void btEstudiantes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGuardarNota_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditarNota_Click(object sender, RoutedEventArgs e)
        {
            E04EditarNotas();
        }


        private void btnCancelarNota_Click(object sender, RoutedEventArgs e)
        {
            E03MostrarNotas();
        }




        public void E00EstadoInicial()
        {
            stackDatosEstudiante.Visibility = Visibility.Collapsed;
            stackCalificaciones.Visibility = Visibility.Collapsed;
            btCalificaciones.Visibility = Visibility.Collapsed;
            btEstudiantes.Visibility = Visibility.Collapsed;

            //Campos habilitados o deshabilitados
            EditarActivado = false;
            CambiarEstudiante = true;
        }

        public void E01MostrarEstudiante()
        {
            stackDatosEstudiante.Visibility = Visibility.Visible;
            stackCalificaciones.Visibility = Visibility.Collapsed;
            btCalificaciones.Visibility = Visibility.Visible;
            btEstudiantes.Visibility = Visibility.Collapsed;

            btnGuardar.Visibility = Visibility.Collapsed;
            btnCancelar.Visibility = Visibility.Collapsed;
            btnEditar.Visibility = Visibility.Visible;

            btCalificaciones.IsEnabled = true;

            EditarActivado = false;

            CambiarEstudiante = true;

            txtWarning.Visibility = Visibility.Collapsed;
        }

        public void E02EditarEstudiante()
        {
            btnGuardar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnEditar.Visibility = Visibility.Collapsed;

            btCalificaciones.IsEnabled = false;

            EditarActivado = true;

            CambiarEstudiante = false;
        }

        public void E03MostrarNotas()
        {
            stackDatosEstudiante.Visibility = Visibility.Collapsed;
            stackCalificaciones.Visibility = Visibility.Visible;
            btCalificaciones.Visibility = Visibility.Collapsed;
            btEstudiantes.Visibility = Visibility.Visible;

            btnGuardarNota.Visibility = Visibility.Collapsed;
            btnCancelarNota.Visibility = Visibility.Collapsed;
            btnEditarNota.Visibility = Visibility.Visible;

            EditarNotasActivado = false;

            btEstudiantes.IsEnabled = true;

            CambiarEstudiante = true;
        }

        public void E04EditarNotas()
        {
            btnGuardarNota.Visibility = Visibility.Visible;
            btnCancelarNota.Visibility = Visibility.Visible;
            btnEditarNota.Visibility = Visibility.Collapsed;

            btEstudiantes.IsEnabled = false;

            EditarNotasActivado = true;

            CambiarEstudiante = false;

        }

        public StudentTableView()
        {
            InitializeComponent();
            //stackCalificaciones.DataContext = this;
            //stackDatosEstudiante.DataContext = this;

            E00EstadoInicial();
            
        }
    }
}
