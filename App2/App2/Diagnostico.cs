using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2
{
    class Diagnostico:INotifyPropertyChanged
    {
        public string diagnosticos;

        public string Diagnosticos
        {
            set
            {
                if (diagnosticos !=value)
                {
                    diagnosticos = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this,new PropertyChangedEventArgs("Diagnosticos"));
                    }
                }
            }
            get
            {
                return diagnosticos;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
