using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace juegoBasta.Domain
{
    [DataContract] 
    public class SalaDeEspera
    {
        [DataMember]
        public int salaId { get; set; }

        [DataMember]
        public List<ClienteUsuario> UsuariosEnSala { get; set; }
       
        public SalaDeEspera()
        {
        }

    }
}
    //private Dictionary<Usuario, string> usuarios;
/*
    public class ControladorSala {

        public SalaDeEspera CrearSalaDeEspera(int id, int limiteJugadores, Usuario anfitrion)
        {
            string estado = "disponible";
            List<Usuario> usuarios = new List<Usuario>(limiteJugadores);
            SalaDeEspera salaDeEspera = new SalaDeEspera (id, estado, usuarios, limiteJugadores, anfitrion);
           // salaDeEspera.JugadoresEnEspera.Add(anfitrion);

            return salaDeEspera; 

        }

        public List<SalaDeEspera> ObtenerSalasDisponibles()
        { /*
            List<SalaDeEspera> salasDeEspera = new List<SalaDeEspera>();
            List<SalaDeEspera> nueva;
            nueva = salasDeEspera.FindAll(x => x. == "disponible"); // Exists(x => x.Estado == "disponible");
            if (nueva != null)
            {
                return nueva;
            }
            else
            {
                return null;
            } 
            return null;
        

        /*
        public bool agregarUsuarioASala(String usuario)
        {
            int tamano = JugadoresEnEspera.Count;
            if (tamano <= limiteParticipantes)
            {
                JugadoresEnEspera.Add(usuario);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removerUsuarioDeSala(String usuario)
        {
            Boolean resultado = JugadoresEnEspera.Remove(usuario);
            if (resultado)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}*/

    
        
       
