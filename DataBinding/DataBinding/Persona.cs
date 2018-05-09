using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataBinding
{
    using System.ComponentModel;
    class Persona:INotifyPropertyChanged
    {
        #region Atributos
        private string nombre;
        private string pais;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                OnPropertyChanged(Nombre);
            }
        }
        public string Pais { get; set; }
        #endregion

        #region Implementación
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion



    }


}
