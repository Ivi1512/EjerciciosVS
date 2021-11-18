using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models
{
    public class NotasModel : INotifyPropertyChanged, ICloneable
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

        private string di { set; get; }

        public string DI
        {
            get { return di; }
            set
            {
                di = value;
                OnPropertyChanged(nameof(DI));
            }
        }

        private string psp { set; get; }

        public string PSP
        {
            get { return psp; }
            set
            {
                psp = value;
                OnPropertyChanged(nameof(PSP));
            }
        }

        private string ad { set; get; }

        public string AD
        {
            get { return ad; }
            set
            {
                ad = value;
                OnPropertyChanged(nameof(AD));
            }
        }

        private string sge { set; get; }

        public string SGE
        {
            get { return sge; }
            set
            {
                sge = value;
                OnPropertyChanged(nameof(SGE));
            }
        }

        private string eie { set; get; }

        public string EIE
        {
            get { return eie; }
            set
            {
                eie = value;
                OnPropertyChanged(nameof(EIE));
            }
        }

        private string pmdm { set; get; }

        public string PMDM
        {
            get { return pmdm; }
            set
            {
                pmdm = value;
                OnPropertyChanged(nameof(PMDM));
            }
        }

        public NotasModel()
        {

        }
    }
}
