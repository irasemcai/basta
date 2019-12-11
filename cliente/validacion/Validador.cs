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
    class Validador 
    {
        public bool ValidarCorreo(string correo)
        {
            String Formato;
            Formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, Formato))
            {
                if (Regex.Replace(correo, Formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool validarLetrasYNumeros(string texto)
        {
            string formato = "[a-zA-Z0-9._]";
            if(Regex.IsMatch(texto, formato))
            {
                if (Regex.Replace(texto, formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }                   
        }

        public bool validarSoloNumeros(string entrada)
        {
            string formato = "[0-9]";
            if (Regex.IsMatch(entrada, formato))
            {
                if (Regex.Replace(entrada, formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

    }
}
