using System;
using gasolineraKalum.Entities;
using gasolineraKalum.Controllers;
using static gasolineraKalum.Util.Printer;
using gasolineraKalum.Menu;

namespace gasolineraKalum
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep();
            WriteTitle("Gasolinera Alumnos K");
            new MenuPrincipal().MostrarMenu();

            /*string[] valores= salida.Split(".");
            Console.WriteLine(valores[2]);*/

            

           // string salida = "GasolineraKalum.Entities.Super";

            //interpolacion $""
           //  Console.WriteLine($"split{salida.Split(".")[2]}");



            //Console.WriteLine(salida.Substring(salida.LastIndexOf(".")+1));
            //Console.WriteLine(salida.LastIndexOf(".")+1));
            /*for (int i = salida.Length - 1 ; i >=0; i--)  
            {
                  if(salida.Substring(i,1).Equals(".")){
                  Console.WriteLine(salida.Substring(i+1,salida.Length-(i+1)));
                  break;
              }  
            }*/

            PrecionarEnter();
           
           /*Bomba super = new Super();
            Bomba regular = new Regular();
            Bomba diesel = new Diesel();
            super.Medida = "Metros Cubicos";
            super.Precio = 24.15;
            super.Capacidad = 1000;
            ((Super)super).Aditivo = 1;
            regular.Medida = "Metros Cubicos";
            regular.Precio = 21.15;
            regular.Capacidad = 1000;
            diesel.Medida = "Metros Cubicos";
            diesel.Precio = 20.15;
            diesel.Capacidad = 1000;
            ((Diesel)diesel).Formula = "Af+045-PU";
            GasolineraController gasolinera = new GasolineraController();
            gasolinera.Agregar(super);
            gasolinera.Agregar(regular);
            gasolinera.Agregar(diesel);
            gasolinera.listar();*/
        }
    }
}
    