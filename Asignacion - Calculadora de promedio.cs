using System;
	

	namespace lenovo
{
	class program{

	static void Main(string[] args){
        double a,b,c,e,l,vSumatoria;

        vSumatoria=0;
        b=0;
        e=0;
            Console.WriteLine("\n"+"\n"+"\n"+ "\n"+"\n" +"################################################" +"\n"+"\n"+"Bienvenido a la calculadora de promedio"+"\n"+"Realizado por Jesús Pérez Gómez"+"\n"+"C.I:28.480.869" +"\n"+ "\n"+"################################################" +"\n"+"\n"+ "Para el correcto funcionamiento de la calculadora"+ "\n"+"se requiere solo el uso de datos numericos"+"\n"+"################################################"+"\n"+"\n"+"\n"+"\n"+"Ingrese la cantidad de cifras a usar"+ "\n");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            c=1;

            do{
                
                Console.WriteLine("Ingrese el digito Nro:"+ c+"\n");
                a = float.Parse(Console.ReadLine());
                    e=e+1;
                    vSumatoria = a + vSumatoria;
                    c=c+1;
                    
                } while (e<l);
                
                b = vSumatoria / l;
                Console.WriteLine("El promedio de las cifras es de:" + b);

}}}
