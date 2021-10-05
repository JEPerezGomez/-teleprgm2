using System;
	

	namespace lenovo
{
	class program{

	static void Main(string[] args){
		string a,b,c, miCadena;
		Console.WriteLine("Bienvenido al escritor de oraciones"+"\n"+"Este escritor funciona con un maximo de 3 palabras");
		Console.WriteLine("\n"+"Ingrese la primera palabra:");
		a=Console.ReadLine();
		Console.WriteLine("\n"+"Ingrese la segunda palabra:");
		b=Console.ReadLine();
		Console.WriteLine("\n"+"Ingrese la tercera palabra:");
		c=Console.ReadLine();
		miCadena=a+""+b+""+""+c;
		Console.WriteLine("\n"+"La oracion construida es:"+miCadena);
	}    

}}
