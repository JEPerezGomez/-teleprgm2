using System;

namespace lenovo
{
    class Program
    {
        public class Promedio
        {
            public float [] numeros = new float [5];
        }

        
        static void Main(string[] args)
        { float a,b,c,d,e,f; 
           Console.WriteLine("Bienvenido a la calculadora de media" +  "\n" + "Esta calculadora funciona con 5 digitos");
           Console.WriteLine("Favor escribir los numeros que se les sacara la media");
           Console.WriteLine("Nro1:");
           a = float.Parse(Console.ReadLine());
           Console.WriteLine("\n"+"Nro2:");
           b = float.Parse(Console.ReadLine());
           Console.WriteLine("\n"+"Nro3:");
           c = float.Parse(Console.ReadLine());
           Console.WriteLine("\n"+"Nro4:");
           d = float.Parse(Console.ReadLine());
           Console.WriteLine("\n"+"Nro5:");
           e = float.Parse(Console.ReadLine());
           f = (a+b+c+d+e)/5;
           Console.WriteLine("La media es:" + f);


        }
    }
}