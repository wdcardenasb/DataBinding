namespace DataBinding
{
    using System.ComponentModel;
    public class Persona : Notificable
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
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }
        }
        public string Pais
        {
            get
            {
                return pais;
            }
            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged();
            }

        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return $"{Nombre} | {Pais}";
        }
        #endregion


    }
}
