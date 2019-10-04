using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace VincularPropriedade
{
    public class Filtro : INotifyPropertyChanged
    {
        private string _nome;
        private bool _ison;

        public string Nome { get { return _nome; } set { NotifyPropertyChanged(); _nome = value;  } }
        public bool isOn { get { return _ison; } set { NotifyPropertyChanged("isNotOn"); _ison = value; } }
        public bool isNotOn { get { return !_ison; } }


        public Filtro(string nome, bool ison)
        {
            Nome = nome;
            isOn = ison;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        //private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    if(PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }


        //}

        void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
