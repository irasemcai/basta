using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoBasta.Domain
{
    abstract class ClaseAbstracta<T>
    {
        protected bastaEntities entidades;
        public ClaseAbstracta()
        {
            Init();
        }

        public void Init()
        {
            entidades = new bastaEntities();
        }

        public abstract int AgregarEntidad (T entidad);
    }
}
