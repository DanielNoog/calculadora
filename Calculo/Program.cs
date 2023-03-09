using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Program
    {
        static double valorum, valordois, res;
        static string ler, reset;
        static void Main(string[] args)
        {
            while (reset != "Q" && reset != "q")
            {

                Console.WriteLine("================================");
                Console.WriteLine("|     Digite 1 para adição     |");
                Console.WriteLine("================================");
                Console.WriteLine("================================");
                Console.WriteLine("|    Digite 2 para subtração   |");
                Console.WriteLine("================================");
                Console.WriteLine("================================");
                Console.WriteLine("|     Digite 3 para divisão    |");
                Console.WriteLine("================================");
                Console.WriteLine("================================");
                Console.WriteLine("| Digite 4 para multiplicação  |");
                Console.WriteLine("================================");
                Console.WriteLine("================================");
                Console.WriteLine("|Digite q para sair do programa|");
                Console.WriteLine("================================");

                ler = (Console.ReadLine());


                switch (ler)
                {
                    case "1":
                        adc();
                        break;

                    case "2":
                        sub();
                        break;

                    case "3":
                        div();
                        break;

                    case "4":
                        mul();
                        break;

                    case "q":
                        fec();
                        break;
                }
                Console.Clear();
            }
        }

        static void adc()

        {
            Console.Clear();
            Console.WriteLine("Você escolheu adição!!");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor");

            valorum = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o segundo valor");

            valordois = double.Parse(Console.ReadLine());
            res = valorum + valordois;

            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("|O resultado da conta é: {0}|", res);
            Console.WriteLine("==================================");

            Console.ReadKey();
        }


        static void sub()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu subtração!!");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor");

            valorum = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o segundo valor");

            valordois = double.Parse(Console.ReadLine());
            res = valorum - valordois;

            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("|O resultado da conta é: {0}|", res);
            Console.WriteLine("==================================");

            Console.ReadKey();
        }


        static void div()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu divisão!!");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor");

            valorum = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o segundo valor");

            valordois = double.Parse(Console.ReadLine());
            res = valorum / valordois;

            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("|O resultado da conta é: {0}|", res);
            Console.WriteLine("==================================");

            Console.ReadKey();
        }


        static void mul()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu Multiplicação!!");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro valor");

            valorum = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o segundo valor");

            valordois = double.Parse(Console.ReadLine());
            res = valorum * valordois;

            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("|O resultado da conta é: {0}|", res);
            Console.WriteLine("==================================");

            Console.ReadKey();
        }
        static void fec()
        {
            System.Environment.Exit(1);
        }
    }
}

