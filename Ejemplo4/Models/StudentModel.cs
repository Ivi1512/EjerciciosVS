using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models
{
    public class StudentModel : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public StudentModel()
        {
            Fecha = DateTime.Today;
        }

        private string id { set; get; }

        public string _id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(_id));
            }

        }

        private string nombre { set; get; }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }

        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                fecha = value;
                OnPropertyChanged(nameof(Fecha));
            }

        }

        private string curso { set; get; }
        public string Curso
        {
            get { return curso; }
            set
            {
                curso = value;
                OnPropertyChanged(nameof(Curso));
            }

        }



    }
}
