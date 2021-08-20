using System;

namespace Calculadoradedivisas
{
    
    public class divisas{
        protected int _origen;
        protected float _cantidad ;
        public int origen{
            get { return _origen;}
            set{ _origen = value;}
        }
        public float cantidad {
            get{return _cantidad;}
            set{_cantidad = value;}
        }
   

    }
    class solperuano : divisas {
        protected float _equiBsper;
        public float equiBsper {
            get{ return _equiBsper;}
            set{ _equiBsper = value;}
        }

    
    }
    public class pesocolombiano : divisas {
        protected float _equiBscol;
        public float equiBscol{ 
            get{return _equiBscol;}
            set{_equiBscol = value;}
        }
    }
    public class dolar : divisas {
        protected float _equiBSdol;
        public float equiBSdol{
            get{return _equiBSdol;}
            set{_equiBSdol = value;}
        
        }

    }
    class program{
        static void Main(string[] args){
            float equiBscol, equiBSdol, equiBsper, cantidad;

            equiBsper = cantidad * 99745500000;
            equiBscol = cantidad * 107536000;
            equiBSdol = cantidad * 4123867;

            
        }
    }
    
    
   



    class controladorDivisas 
    {
        private vista_Consola oDisplay;
        public controladorDivisas ()
        {
            oDisplay = new vista_Consola();
            if (oDisplay.origen == 1){
                solperuano oSolperuano;
                oSolperuano = new solperuano (equiBsper);
                oDisplay.origen = oSolperuano.origen;
                oDisplay.MuestraTotales();
            }
            if(oDisplay.origen == 2){
                pesocolombiano oPesocolombiano;
                oPesocolombiano = new pesocolombiano (equiBscol);
                oDisplay.origen = oPesocolombiano.origen;
                oDisplay.MuestraTotales();
            }
            if(oDisplay.origen == 3){
                dolar oDolar;
                oDolar = new dolar (equiBSdol);
                oDisplay.origen = oDolar.origen;
                oDisplay.MuestraTotales();
            }
    }
    class vista_Consola{
        public float _equiBscol;
        public float _equiBSdol;
        public float _equiBsper;
        public int _origen;
        public float _cantidad;

        public float cantidad{
            get{return _cantidad;}
            set{_cantidad = value;}
        }

        public float equiBscol {
            get {return _equiBscol;}
            set {_equiBscol = value;}
        }
        public float equiBsper {
            get {return _equiBsper;}
            set {_equiBsper = value;}
        }
        public float equiBSdol {
            get {return _equiBSdol;}
            set {_equiBSdol = value;}
        }
        public int origen {
            get {return _origen;}
            set {_origen = value;}
        }
    
    public vista_Consola()
    {
        this.ObtieneValores();

    }
    
    
    private void ObtieneValores()
    {
        Console.WriteLine("Bienvenido a la convertidora de divisas a bolivares"+"\n"+"Porfavor seleccione el tipo de divisa que desea convertir a bolivares:"+"\n"+"Sol Peruano (1)"+"\n"+"Peso Colombiano (2)"+"\n"+"Dolar (3)");
        switch (Console.ReadLine())
        {
            case "1":
            this.origen = 1;
            Console.WriteLine("Ingrese la cantidad de Soles peruanos que desea convertir a bolivares:");
            l = float.Parse(Console.ReadLine());
            cantidad = float.Parse(Console.ReadLine());
            Console.WriteLine(equiBsper);
            break;
            case "2":
            this.origen = 2;
            cantidad = float.Parse(Console.ReadLine());
            Console.WriteLine(equiBscol);
            break;
            case"3":
            this.origen = 3;
            cantidad = float.Parse(Console.ReadLine());
            Console.WriteLine(equiBSdol);
            break;

        }
        Console.WriteLine("Presione cualquier tecla para cerrar este menu");
        Console.ReadKey();
    }
    public void MuestraTotales(){
        Console.WriteLine("Presione cualquier tecla para cerrar este menu");
        Console.ReadKey();
    }}
    }



    
}
