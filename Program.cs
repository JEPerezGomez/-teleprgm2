using System;

namespace lenovo
{
    public class Figuras{
        protected float _area;
        

        public float area {
            get {return _area;}
            set {_area = value;}
        }
        
        public Figuras (float _area){}
        public Figuras (){
            this._area = area;
        }



    }
    public class Elipse : Figuras {
        protected float _radiomayor;
        protected float _radiomenor;

        public float radiomayor{
            get {return _radiomayor;}
            set {_radiomayor = value;}
        }
        public float radiomenor{
            get {return _radiomenor;}
            set {_radiomenor = value;}
        }
        public Elipse (){}
        public Elipse (float _area, float _radiomayor, float _radiomenor)
        :base(_area){
            this._radiomayor = radiomayor;
            this._radiomenor = radiomenor;
        }
    }
    public class Cuadrado : Figuras {
        protected float _lado;

        public float lado {
            get {return _lado;}
            set {_lado = value;}
        }
        public Cuadrado (){}
        public Cuadrado (float _area, float _lado)
        :base(_area){
            this._lado = lado;
    }
    public class Circulo : Figuras {
        protected float _radio;

        public float radio {
            get {return _radio;}
            set {_radio = value;}
        }
        public Circulo (){}
        public Circulo (float _area, float _radio)
        :base(_area){
            this._radio = radio;
    }
    public class Rectangulo : Cuadrado {
        protected float _baser;
        protected float _alturar;

        public float baser {
            get {return _baser;}
            set {_baser = value;}
        }
        public float alturar {
            get {return _alturar;}
            set {_alturar = value;}
        }
        public Rectangulo (){}
        public Rectangulo (float _area, float _lado, float _baser, float alturar)
        :base(_area, _lado){
            this._baser = baser;
            this._alturar = alturar;


    }
    public class Triangulo : Figuras {
        protected float _baset;
        protected float _alturat;

        public float baset{
            get {return _baset;}
            set {_baset = value;}
        }
        public float alturat{
            get {return _alturat;}
            set {_alturat = value;}
        }
        public Triangulo (){}
        public Triangulo (float _area, float _alturat, float _baset)
        :base(_area){
            this._alturat = alturat;
            this._baset = baset;

    }


    class Program
    {
        

        
        static void Main(string[] args)
        {float y,z,a,b,c,d,_alturat,_baset,_baser,_alturar,_lado; 
         float _radio, _radiomayor, _radiomenor;
         float promedio; 
         promedio = 3.14F;
         int l;
         l=0;
            Console.WriteLine("Buenas, bienvenido a la calculadora de area de figuras." + "\n" + "Por favor ingrese la cantidad de figuras a calcular el area (En numeros porfavor)");
            y = float.Parse(Console.ReadLine());
            do{
                
                Console.WriteLine("Ingrese el tipo de Figura (1) Elipse, (2) Cuadrado, (3)Circulo, (4) Rectangulo, (5) Triangulo");
                y = float.Parse(Console.ReadLine());
                if (y == 1) {
                    Console.WriteLine("Selecciono Elipse" + "\n" + "Porfavor ingrese el radio mayor");
                    _radiomayor = float.Parse(Console. ReadLine());
                    Console.WriteLine("\n"+"Ahora el radio menor");
                    _radiomenor = float.Parse(Console.ReadLine());
                    z=_radiomayor*_radiomenor*promedio;
                    l=l+1;
                    _areae = z;
                    Console.WriteLine("El area de la elipse introducida es: " + z); 
                    Console.ReadKey();


                }
                if (y == 2){
                    Console.WriteLine("Selecciono Cuadrado" + "\n" + "Porfavor ingrese el lado del Cuadrado");
                    _lado = float.Parse(Console. ReadLine());
                    
                    a=_lado*_lado;
                    _areacu = a;
                    Console.WriteLine("El area del cuadrado introducido es:" + a);
                    Console.ReadKey();
                    l=l+1;
                }
                if (y == 3){
                    Console.WriteLine("Selecciono Circulo" + "\n" + "Porfavor ingrese el radio del circulo");
                    _radio = float.Parse(Console.ReadLine());
                    
                    b=_radio*_radio*promedio;
                    Console.WriteLine("El area del circulo es: " + b);
                    Console.ReadKey();
                    l=l+1;
                }
                if (y == 4){
                    Console.WriteLine("Selecciono Rectangulo" + "\n" + "Porfavor ingrese la altura");
                    _alturar = float.Parse(Console. ReadLine());
                    Console.WriteLine("Ahora la base");
                    _baser = float.Parse(Console.ReadLine());
                    c=_alturar*_baser;
                    Console.WriteLine("El area del rectangulo es: " + c);
                    l=l+1;
                }
                if (y == 5){
                    Console.WriteLine("Selecciono Triangulo" + "\n" + "Porfavor ingrese la altura del triangulo");
                    _alturat = float.Parse(Console. ReadLine());
                    Console.WriteLine("Ahora la base del triangulo");
                    _baset = float.Parse(Console.ReadLine());
                    d=(_baset*_alturat)/2;
                    Console.WriteLine("El area del triangulo es: " + d);
                    l=l+1;
                }
                else {
                    Console.WriteLine("Selecciono una opcion no valida, intente de nuevo porfavor" + "\n");
                    
                }

                


            } while (y == l);
            Console.ReadKey();
        }}}}}}}