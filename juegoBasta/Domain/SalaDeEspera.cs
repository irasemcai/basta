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
        protected int idSala;
        protected string estado;
        public List<Usuario> jugadoresEnEspera;
        protected int limiteJugadores;
        protected Usuario anfitrion;
       public SalaDeEspera(int id, string estado, List<Usuario> usuarios, int limiteJugadores, Usuario anfitrion)
        {
            this.IdSala = id;
            this.estado = estado;
            this.JugadoresEnEspera = usuarios;
            this.limiteJugadores = limiteJugadores;
            this.anfitrion = anfitrion;
        }
       
       
        [DataMember]
        public int IdSala
        {
            get { return idSala; }
            set { idSala = value; }
        }
        
        [DataMember]
        protected string Estado {
            get { return estado; }
            set { estado = value; }
        }
        [DataMember]
        public List<Usuario> JugadoresEnEspera {
            get { return jugadoresEnEspera; }
            set { jugadoresEnEspera = value; }
        }
        [DataMember]
        private int LimiteJugadores {
            get { return limiteJugadores; }
            set { limiteJugadores = value; }
        }
        [DataMember]
        private Usuario Anfitrion {
            get { return anfitrion; }
            set { anfitrion = value; }
        }
    }
    //private Dictionary<Usuario, string> usuarios;

    public class ControladorSala {

        public SalaDeEspera CrearSalaDeEspera(int id, int limiteJugadores, Usuario anfitrion)
        {
            string estado = "disponible";
            id = 1;
            List<Usuario> usuarios = new List<Usuario>(limiteJugadores);
            SalaDeEspera salaDeEspera = new SalaDeEspera (id, estado, usuarios, limiteJugadores, anfitrion);
            salaDeEspera.JugadoresEnEspera.Add(anfitrion);

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
            } */
            return null;
        }

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
        } */
    }
}

    
        
       
