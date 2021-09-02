using System;

namespace Calculadoradedivisas
{
       
    
    
    public abstract class divisas{
        
        protected float _cantidad ;
        
        public float cantidad {
            get{return _cantidad;}
            set{_cantidad = value;}
        }
        public abstract float equivalente {get;}

   

    }
    class solperuano : divisas {
        public  solperuano (float tigre)
        {tigre=cantidad;}
        public override float equivalente { get {return (cantidad * 99745500000);}}
            
    }

    public class pesocolombiano : divisas {
        public  pesocolombiano (float tigre){
            tigre = cantidad;
        }
        public override float equivalente { get {return (cantidad * 107536000);}}
    }
    
    public class dolar : divisas {
        
        public  dolar (float tigre){
            tigre= cantidad;}
        public override float equivalente {get { return(cantidad * 4123867);}}
            
        

    }
    
    
   



    class controladorDivisas 
    {
        protected float _koala;
        public float koala {
            get{return _koala;}
            set{_koala = value;}
        }
        public static void Main (){
            controladorDivisas ave = new controladorDivisas ();
            vista_Consola puma = new vista_Consola ();
            if (puma.origen == 1){
                solperuano tortuga = new solperuano (puma.cantidadtrans);
                ave.koala = tortuga.equivalente;
            }
            if (puma.origen == 2){
                pesocolombiano tortuga = new pesocolombiano (puma.cantidadtrans);
                ave.koala = tortuga.equivalente;
            }
            if (puma.origen == 3){
                dolar tortuga = new dolar (puma.cantidadtrans);
                ave.koala = tortuga.equivalente;
            }
            vista_Consola peace = new vista_Consola ();
            
        }
    }






    class vista_Consola{
        public float _equivalente;
        public float _origen;
        public float _cantidadtrans;

        public float equivalente{
            get{return _equivalente;}
            set{_equivalente = value;}
        }

        public float cantidadtrans{
            get{return _cantidadtrans;}
            set{_cantidadtrans = value;}
        }
        public float origen {
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
        origen = float.Parse (Console.ReadLine());
        if (origen == 1){
    
            Console.WriteLine("Ha seleccionado Sol peruano"+"\n"+"Ingrese la cantidad que desea convertir a bolivares:");
            cantidadtrans = float.Parse(Console.ReadLine());
            equivalente=cantidadtrans * 99745500000;
            }
        if (origen == 2){
            
            Console.WriteLine("Ha seleccionado Peso colombiano"+"\n"+"Ingrese la cantidad que desea convertir a bolivares:");
            cantidadtrans = float.Parse(Console.ReadLine());
            equivalente=cantidadtrans * 107536000;
            }
        if (origen == 3){

            Console.WriteLine("Ha seleccionado Dolar"+"\n"+"Ingrese la cantidad que desea convertir a bolivares:");
            cantidadtrans = float.Parse(Console.ReadLine());
            equivalente= cantidadtrans * 4123867;

        }
        
        Console.WriteLine("El total es de: "+equivalente+"Bs");
        Environment.Exit(0);
    }
    
}
    }