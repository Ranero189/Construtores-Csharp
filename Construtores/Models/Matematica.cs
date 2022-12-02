namespace Construtores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Matematica(int x, int y)
        {
            X = x; 
            Y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }
        public void somar()
        {
            Calculadora.somar(X, Y);
        }
          public void subtrair()
        {
            Calculadora.subtrair(X, Y);
        }
        public void EventHandler()
        {
            System.Console.WriteLine("Método executado");
        }
    }
}