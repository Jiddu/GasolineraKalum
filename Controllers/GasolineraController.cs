using System;
using System.Collections.Generic;
using gasolineraKalum.Entities;
using gasolineraKalum.interfaces;
using static gasolineraKalum.Util.Printer;
using static System.Console;
namespace gasolineraKalum.Controllers
{
    public class GasolineraController : IMantenimiento
    {
        private List<Bomba> listaDeBombas = new List<Bomba>();

        public void Agregar(object Elemento)
        {
            this.listaDeBombas.Add((Bomba)Elemento);
        }

        public object Buscar(string id)
        {
            Bomba resultado = null;
            foreach (var item in listaDeBombas)
            {
                if (item.Id.Equals(id,StringComparison.Ordinal))
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }

        public void Eliminar(object Elemento)
        {
            this.listaDeBombas.Remove((Bomba)Elemento);
        }

        public void listar()
        {
            WriteTitle("Listado de Bombas de Gasolina");
            foreach (var item in listaDeBombas)
            {
                WriteLine(item);
            }
        }

        public void Modificar(object Elemento)
        {
            
        }
    }
}