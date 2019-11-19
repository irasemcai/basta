
namespace juegoBasta.Domain
{
   public abstract class Entidad<T>
    {
        protected bastaEntities Entidades;
        public Entidad()
        {
            Init();
        }

        public void Init()
        {
            Entidades = new bastaEntities();
        }

        public abstract int agregarEntidad (T Entidad);
    }
}
