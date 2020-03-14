using System;
namespace gasolineraKalum.Util
{
    public static class Printer
    {
        public static void Beep(int hz = 3000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
        public static void DrawLine(int size = 10)
        {
            Console.WriteLine("".PadLeft(size, '='));
        }

        public static void WriteTitle(string title)
        {
            var tamaño = title.Length * 3;
            DrawLine(tamaño);
            Console.WriteLine($"|{title}|");
            DrawLine(tamaño);
        }


        public static void PrecionarEnter()
        {
            Console.WriteLine("Presione Enter");
            Console.ReadKey();
        }
    }
}