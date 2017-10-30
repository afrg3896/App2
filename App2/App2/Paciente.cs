using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2
{
    class Paciente: INotifyPropertyChanged
    {
        public string nombreC;
        public string diagnostic;

        public string NombreC
        {
            set
            {
                if (nombreC != value)
                {
                    nombreC = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("NombreC"));
                    }
                }
            }
            get
            {
                return nombreC;
            }
        }
        public string Diagnostic
        {
            set
            {
                if (diagnostic != value)
                {
                    diagnostic = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Diagnostic"));
                    }
                }
            }
            get
            {
                return diagnostic;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
