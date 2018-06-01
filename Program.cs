using System;

namespace myFutbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase MyFutbol");
            Balon adidas = new Balon();
            adidas.Inflar();
           

            Futbolista  Messi = new Futbolista();
            Messi.Jugar();

            Cancha Old = new Cancha();
            Old.Sostener();

            Camiseta Manchester = new Camiseta();
            Manchester.Vestir();

            Botines Nike = new Botines();
            Nike.Proteger();
        }
    }
}
