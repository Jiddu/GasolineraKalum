using  gasolineraKalum;
namespace gasolineraKalum.Entities
{
    public class Super : Bomba
    {
        public int Aditivo { get; set; }
        public Super()
        {
        }
        public Super(int aditivo,double precio,int capacidad,string medida) : base(precio,capacidad,medida)
        {          
            this.Aditivo = aditivo;
        }
    }
}