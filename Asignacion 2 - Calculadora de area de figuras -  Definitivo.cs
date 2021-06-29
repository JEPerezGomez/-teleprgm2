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

        {Figuras ofiguras = new Figuras();
         double pi = Math.PI;
         double b,z,_areae,_areacu;
         float e,l,y,a,c,d,_alturat,_baset,_baser,_alturar,_lado; 
         float _radio, _radiomayor, _radiomenor;
         e=0;
            Console.WriteLine("\n"+"\n"+"\n"+ "\n"+"\n" +"################################################" +"\n"+"\n"+"Bienvenido a la calculadora de area de figuras"+"\n"+"Realizado por Jesús Pérez Gómez"+"\n"+"C.I:28.480.869" +"\n"+ "\n"+"################################################" +"\n"+"\n"+ "Para el correcto funcionamiento de la calculadora"+ "\n"+"se requiere solo el uso de datos numericos"+"\n"+"################################################"+"\n"+"\n"+"\n"+"\n"+"Ingrese la cantidad de figuras a calcular el area"+ "\n");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            do{
                
                Console.WriteLine("Ingrese el tipo de Figura:"+ "\n" + "(1) Elipse" + "\n"+ "(2) Cuadrado" + "\n"+ "(3) Circulo" + "\n" + "(4) Rectangulo" + "\n" + "(5) Triangulo" +"\n" +"----------------------------------");
                y = float.Parse(Console.ReadLine());
                if (y == 1) {
                    Console.WriteLine("Selecciono Elipse" + "\n" + "----------------------------------" +"\n"+ "Porfavor ingrese el radio mayor");
                    _radiomayor = float.Parse(Console. ReadLine());
                    Console.WriteLine("\n"+"Ahora el radio menor");
                    _radiomenor = float.Parse(Console.ReadLine());
                    z=_radiomayor*_radiomenor*pi;
                    e=e+1;
                    _areae = z;
                    Console.WriteLine("============================================="+"\n" + "El area de la elipse es: " + z + "\n" + "============================================="+"\n"+"\n"); 
                    


                }
                if (y == 2){
                    Console.WriteLine("Selecciono Cuadrado" + "\n" + "----------------------------------"+"\n"+"Porfavor ingrese el lado del Cuadrado");
                    _lado = float.Parse(Console. ReadLine());
                    
                    a=_lado*_lado;
                    _areacu = a;
                    Console.WriteLine("============================================="+"\n"+"El area del cuadrado es: " + a + "\n" +"============================================="+"\n"+"\n");
                    
                    e=e+1;
                }
                if (y == 3){
                    Console.WriteLine("Selecciono Circulo"+"\n" +"----------------------------------"+ "\n" + "Porfavor ingrese el radio del circulo");
                    _radio = float.Parse(Console.ReadLine());
                    
                    b=_radio*_radio*Math.PI;
                    Console.WriteLine("============================================="+"\n"+"El area del circulo es: " + b +"\n"+ "============================================="+"\n"+"\n");
                    
                    e=e+1;
                }
                if (y == 4){
                    Console.WriteLine("Selecciono Rectangulo"+"\n"+"----------------------------------"+ "\n" + "Porfavor ingrese la altura");
                    _alturar = float.Parse(Console. ReadLine());
                    Console.WriteLine("Ahora la base");
                    _baser = float.Parse(Console.ReadLine());
                    c=_alturar*_baser;
                    Console.WriteLine("============================================="+"\n"+"El area del rectangulo es: " + c+"\n" +"============================================="+"\n"+"\n");
                    e=e+1;
                }
                if (y == 5){
                    Console.WriteLine("Selecciono Triangulo" + "\n" + "Porfavor ingrese la altura del triangulo");
                    _alturat = float.Parse(Console. ReadLine());
                    Console.WriteLine("Ahora la base del triangulo");
                    _baset = float.Parse(Console.ReadLine());
                    d=(_baset*_alturat)/2;
                    Console.WriteLine("============================================="+"\n"+"El area del triangulo es: " + d+"\n"+"============================================="+"\n"+"\n");
                  
                    
                    e=e+1;
                }
                
                

                


            } while (e < l);
            Console.WriteLine("\n"+"\n"+"############################"+"\n"+"####  Fin del programa  ####"+"\n"+"############################");
            
        }}}}}}}