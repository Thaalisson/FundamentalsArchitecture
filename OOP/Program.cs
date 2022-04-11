using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the operation:");
            Console.WriteLine("");
            Console.WriteLine("1 - Encapsulation");
            Console.WriteLine("2 - Inheritance Composition 1");
            Console.WriteLine("3 - Inheritance Compositiono 2");
            Console.WriteLine("4 - Interface Implementation");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new AutomacaoCafe().ServirCafe();
                    break;
                case '2':
                    new TestesHerancaComposicao();
                    break;
                case '3':
                    new TestesHerancaComposicao2();
                    break;
                case '4':
                    new TesteInterfaceImplementacao();
                    break;
            }

            Main();
        }
    }
}
