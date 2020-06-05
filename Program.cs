using System;

namespace aula9_cauculadora
{
     class Program
    {
        static void Main(string[] args)
        {

            CauculadoraCientifica calc = new CauculadoraCientifica();
            Console.WriteLine("Faça um cálculo abaixo \n Utilize: \n + para soma, - para subtração, x para multiplicação e / para divisão");
            string calculo = Console.ReadLine();
            calc.ManipularCalculos(calculo);
            Console.WriteLine("Resultado: "+ calc.resultado);

            calc.resultado = 0;

            System.Console.WriteLine("Digite números separados por vírgula:");
            calc.CaucularMedia( Console.ReadLine() );
            System.Console.WriteLine("Média: "+calc.resultado);

        }
    }
}