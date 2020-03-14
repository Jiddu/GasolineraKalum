namespace gasolineraKalum.interfaces
{
    public interface IMantenimiento
    {
         void Agregar(object Elemento);
         void Modificar(object Elemento);
         void Eliminar(object Elemento);
         object Buscar(string id);
         void listar();
    }
}