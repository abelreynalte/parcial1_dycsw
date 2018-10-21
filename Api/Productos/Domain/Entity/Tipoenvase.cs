namespace DyCswParcial1.Api.Productos.Domain.Entity
{
    public class Tipoenvase
    {
        public virtual int Id { get; protected set; }
        public virtual string Descripcion { get; }
        public virtual bool Activo { get; }
    }
}
