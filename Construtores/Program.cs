using Construtores.Models;

namespace Construtores
{
    class Program
    {
        public delegate void operação(int x , int y);
        static void Main(string[] args)
        {
            // Pessoa p1 = new Pessoa("Andreia", "Grecco");
            // p1.Apresentar();

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Aluno a1 = new Aluno("Henrique", "Grecco", "Matematica");
            // a1.Apresentar();

            // Data d1 = new Data();
            // d1.SetMes(12);
            // d1.Mes = 12;
            // System.Console.WriteLine(d1.Mes);
            // d1.Apresentar();
            
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);
            // pi = 0; 

            // operação op = new operação (Calculadora.somar);
            // op += Calculadora.subtrair; // multi delegate operator
            // op.Invoke(90 , 10);

            Matematica m = new Matematica(10 , 20);
            m.somar();
            m.subtrair();

        }
    }
}
