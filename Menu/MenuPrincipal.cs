using static gasolineraKalum.Util.Printer;
using static System.Console;
using System;
using gasolineraKalum.Controllers;
using gasolineraKalum.Entities;

namespace gasolineraKalum.Menu
{
    public class MenuPrincipal
    {
        private GasolineraController controller = new GasolineraController();

        public void MostrarMenu()
        {
            try
            {
                int opcion = 0;
                do
                {
                    Clear();
                    WriteTitle("Administracion de Bombas");
                    WriteLine("1. Agregar");
                    WriteLine("2. Eliminar");
                    WriteLine("3. Buscar");
                    WriteLine("4. Listar");
                    WriteLine("5. Modificar");
                    WriteLine("0. Salir");
                    WriteLine("Ingrese una opcion ===>");
                    string respuesta = ReadLine();
                    opcion = Convert.ToByte(respuesta);
                    WriteLine("Opcion seleccionada {0}", opcion);
                    switch (opcion)
                    {
                        case 1:
                            agregarTipoBomba();
                            break;
                        case 2:
                            eliminar();
                            break;
                        case 3:
                            Buscar();
                            break;
                        case 4:
                            listarBombas();
                            break;
                        case 5:
                            Modificar();
                            break;
                        case 0:
                            break;
                        default:
                            WriteLine("No existe la opcion");
                            break;
                    }
                } while (opcion != 0);

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        private void agregarTipoBomba()
        {
            WriteTitle("Tipo de Bomba");
            WriteLine("1. Super");
            WriteLine("2. Regular");
            WriteLine("3. Diesel");
            WriteLine("0. Salir");
            WriteLine("Seleccione una opcion ==>");
            string respuesta = ReadLine();
            if (respuesta.Equals("1"))
            {
                Bomba super = new Super();
                agregarElementos(super);
            }
            else if (respuesta.Equals("2"))
            {
                Bomba regular = new Regular();
                agregarElementos(regular);
            }
            else if (respuesta.Equals("3"))
            {
                Bomba diesel = new Diesel();
                agregarElementos(diesel);
            }
        }
        private void agregarElementos(Bomba elemento)
        {
            WriteLine("Ingrese un precio");
            elemento.Precio = Convert.ToDouble(ReadLine());
            WriteLine("Ingrese una medida");
            elemento.Medida = ReadLine();
            WriteLine("Ingrese una cantidad");
            elemento.Capacidad = Convert.ToInt16(ReadLine());
            if (elemento.GetType() == typeof(Super))
            {
                WriteLine("Ingrese numero de aditivos");
                ((Super)elemento).Aditivo = Convert.ToInt16(ReadLine());
            }
            else if (elemento.GetType() == typeof(Diesel))
            {
                WriteLine("Ingrese formula");
                ((Diesel)elemento).Formula = ReadLine();
            }
            PrecionarEnter();
            controller.Agregar(elemento);
        }

        private void listarBombas()
        {
            WriteLine("Metodo lista");
            controller.listar();
            PrecionarEnter();
        }

        private void eliminar()
        {
            controller.listar();
            WriteLine("Ingrese el id a eliminar");
            string id = Console.ReadLine();
            Object elemento = Buscar(id);
            if (elemento != null)
            {
                WriteLine("Esta seguro de eliminar (S/N)");
                string respuesta = Console.ReadLine();
                if (respuesta.Equals("s"))
                {
                    controller.Eliminar(elemento);
                    WriteLine("Registro eliminar !!!");
                    ReadKey();
                }
            }
        }

        private void Buscar()
        {
            WriteLine("Ingrese el Id");
            string id = ReadLine();
            Object elemento = controller.Buscar(id);
            if (elemento != null)
            {
                WriteLine("El elemento buscado es "+elemento);
            }else
            {
                WriteLine("no existen registros");
            }
            ReadKey();
        }

        public void Modificar()
        {
            controller.listar();
            WriteLine("Ingrese el Id");
            string id = ReadLine();
            Object elemento = Buscar(id);
            if(elemento != null)
            {
                ((Bomba)elemento).Capacidad = 2020;
                WriteLine("registro modificado");
            }else
            {
                WriteLine("No exiten registros");
            }
            ReadKey();

        }



        private Object Buscar(string id)
        {
            return controller.Buscar(id);
        }





    }
}