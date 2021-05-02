using System;


namespace Clinica_Veterinaria{
 public class Animal
{
protected string _nombre;     
protected string _tipo;
protected string _marcadecomidafavorita;
protected float _edad;

public string nombre
{get {return _nombre;}
set {_nombre = value;}
}

public string tipo
{get {return _tipo;}
 set {_tipo = value;}

}

public string marcadecomidafavorita
{     get {return _marcadecomidafavorita;}
    set {_marcadecomidafavorita = value;}
    }
public float edad 
{
    get {return _edad;}
    set {_edad = value;}
}
public Animal (string _tipo, string _colordepelo, string _marcadecomidafavorita, float _edad)
{}   
public Animal ()
{ this._nombre = nombre;
  this._tipo = tipo;
  this._marcadecomidafavorita = marcadecomidafavorita;
  this._edad = edad; 

}
}

public class Perro : Animal
{

protected string _colordepelo;
protected string _raza;
private string colordepelo{
    get {return _colordepelo;}
    set {_colordepelo = value;}
    
  
}
private string raza{
    get {return _raza;}
    set {_raza = value;}
}
public Perro (){

}
public Perro (string _nombre, string _tipo, string _colordepelo, string _marcadecomidafavorita, float _edad, string _raza)
:base(_nombre, _tipo, _marcadecomidafavorita, _edad)
{
    this._colordepelo = _colordepelo;
    this._raza = _colordepelo;
}
}


    class Program {
        static void Main(string[] args)
        {
            float x;
            float y;
            string _colordepelo;
            string _raza;
            string _nombre;
            string _tipo;
            string _marcadecomidafavorita;
            float _edad;
            do{
            Console.WriteLine("\n" + "Bienvenido a la Clinica Veterinaria Peluditos," + "\n");
            Console.WriteLine("Cual es el nombre de su mascota");
            _nombre = Console.ReadLine();
            Console.WriteLine("\n" + "Tiene su mascota pelo? (1)SI o (2)NO, sea cuidadoso con su eleccion ");
            y = float.Parse(Console.ReadLine());
            if (y == 1){
                
                Console.WriteLine("\n" + "De que color es el pelo de su mascota?, ");
                _colordepelo = Console.ReadLine();

            }
            else {
                Console.WriteLine("\n" + "Su mascota no tiene pelo, ");
            _colordepelo = "no tiene";
            }
            Console.WriteLine("\n" + 
            "Por favor, ingrese el tipo de mascota que tiene (Perro, Gato, Hamster, Araña,   etc)");
            _tipo = Console.ReadLine();
            Console.WriteLine("\n" + "Cual es la raza de su mascota? (Doberman, Yokshire, etc)");
            _raza = Console.ReadLine();

            Console.WriteLine("\n" + "Cual es la marca favorita de comida de su mascota?, ");
            _marcadecomidafavorita = Console.ReadLine();

            do{
                Console.WriteLine("\n" + "Ingrese la edad de su mascota (en el caso de tener unos meses de vida ingresar  0), ");
                _edad = float.Parse(Console.ReadLine());
                if (_edad < 0){
                    Console.WriteLine("Edad incorrecta, su mascota no puede tener menos de 0 años de edad, intente nuevamente");
                }
                else{
                    Console.WriteLine("\n");
                }
            } while (_edad < 0);


            
            Console.WriteLine("================================================================================" +"\n" +
             "El nombre de su mascota es " + _nombre);
           
            Console.WriteLine("\n" + "Es un(a) " + _tipo + "\n");
            if (y == 1){
                Console.WriteLine("De pelo color " + "\n" + _colordepelo + "\n");}
                else{
                    Console.WriteLine("No posee pelo " + "\n");
                } 
                
                Console.WriteLine("De raza " + _raza + "\n");
                Console.WriteLine("Su marca favorita de comida es " + _marcadecomidafavorita + "\n");
                Console.WriteLine("Y su edad es de " + _edad + " año(s), (en caso de ser 0 años, decir al veterinario cuantos  meses tiene la mascota)" + "\n" + "================================================================================");
           Console.WriteLine("\n" + "Si esta informacion es correcta ingrese (1), en caso contrario ingrese (2) para reiniciar el proceso, por favor sea cuidadoso al momento de ingresar los datos, ");
            x = float.Parse(Console.ReadLine());
           
            } while (x == 2);
           
            Console.WriteLine("\n" + "Gracias por llenar el formulario");
            Console.ReadKey();
        }
    }

}