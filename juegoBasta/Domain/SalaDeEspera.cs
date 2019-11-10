using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoBasta.Domain
{
    class SalaDeEspera
    {
        // private int numeroSala;
        private string Estado { get; set; }
        private List<String> JugadoresEnEspera;
        private string nombre;
        private int limiteParticipantes;
        private string Anfitrion;

        
        public SalaDeEspera(string nombre, int limiteParticipantes, string anfitrion)
        {
            this.nombre = nombre;
            this.limiteParticipantes = limiteParticipantes;
            this.JugadoresEnEspera= JugadoresEnEspera = new List<String>(limiteParticipantes);
            this.Estado = "disponible";
            this.Anfitrion = anfitrion;
        }
        
        public SalaDeEspera()
        {

        }
        
        public List<SalaDeEspera> ObtenerSalasDisponibles()
        {
            List<SalaDeEspera> salasDeEspera = new List<SalaDeEspera>();
            List<SalaDeEspera> nueva;
            nueva = salasDeEspera.FindAll(x => x.Estado == "disponible"); // Exists(x => x.Estado == "disponible");
            if (nueva != null)
            {
                return nueva;
            }
            else
            {
                return null;
            }            
        }

        public bool agregarUsuarioASala(String usuario)
        {
            int tamano = JugadoresEnEspera.Count;
            if(tamano <= limiteParticipantes)
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
}
