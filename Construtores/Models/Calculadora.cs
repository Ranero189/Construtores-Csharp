namespace Construtores.Models
{
    public class Calculadora
    {
        // delegate
        public delegate void DelegateCalculadora();
        // evento
        public static event DelegateCalculadora ?EventoCalculadora;
        public static void somar(int x , int y)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"A soma é: {x + y}");
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }

        }
        public static void subtrair(int x , int y)
        {
            if(EventoCalculadora != null)
            {
                System.Console.WriteLine($"A subtração é: {x - y}");
                EventoCalculadora();
            }
            else
            {
               System.Console.WriteLine("Nenhum inscrito"); 
            }
        }
    }
}