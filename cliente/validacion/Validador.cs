using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace cliente.validacion
{
    class Validador : IDataErrorInfo
    {
        public string nombreUsuario;

        public string Name
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Error
        {
            get
            {
                return this[string.Empty];
            }
        }

        public string this[string propertyName]
        {
            get
            {
                string result = string.Empty;
                propertyName = propertyName ?? string.Empty;
                if (propertyName == string.Empty || propertyName == "Name")
                {
                    if (string.IsNullOrEmpty(this.Name))
                    {
                        result = "Name cannot be blank!";
                    }
                }
                else
                {
                    bool resultado = Regex.IsMatch(propertyName, @"^[a-zA-Z]+$");
                    if (resultado==false)
                    {
                        result="Solo introduce letras" ;
                    }
                    
                }
                return result;
            }
        }
       /* public bool esValido()
        {
            
        }*/
    }
}
