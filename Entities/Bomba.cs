
using System;
using gasolineraKalum.interfaces;

namespace gasolineraKalum.Entities
{
    public class Bomba : IControlBomba
    {
        public string Id { get; set; }
        public double Precio { get; set; }
        public int Capacidad { get; set; }
        public string Medida { get; set; }


        public Bomba()
        {
            this.Id = GeneraId();
        }
        public Bomba(double precio, int capacidad, string medida)
        {
            this.Id = GeneraId();
            this.Precio = precio;
            this.Capacidad = capacidad;
            this.Medida = medida;
        }
        private string GeneraId()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public void Despachar(int cantidad)
        {
            if (this.Capacidad >= cantidad)
            {
                this.Capacidad -= cantidad;
            }
        }
        public int VerNivelCapacidad()
        {
            return this.Capacidad;
        }
        
        public override string ToString()
        {
            //return $"{{\"Id\": \"{this.Id}\", \"Capacidad\": {this.Capacidad},\"Tipo\" : {this.GetType()}}}";
            return $"{{\"Id\": \"{this.Id}\", \"Capacidad\": {this.Capacidad},\"Tipo\" : { this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf(".")+1)}}}";

        }
    }
}