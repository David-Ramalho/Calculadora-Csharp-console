using System;

namespace IFelse
{
    class Program
{
    static void Main(string[] args)
    {
            //variaveis
            int a;
            int b;
            int result;
            string nome = "";
            int op;
            
            //Pergunta o nome.
            Console.WriteLine("qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Muito obrigado!");

            // pergunta a primeira variavel.
            Console.Write(nome);
            Console.Write(",qual valor do primeiro número inteiro? ");
            a= int.Parse(Console.ReadLine());

            //pergunta segunda variavel.

            Console.Write(nome);
            Console.Write(", qual o valor do segundo número inteiro? ");
            b = int.Parse(Console.ReadLine());

            //vai definir as operações

            Console.WriteLine("qual operação queres realizar?");
            Console.WriteLine("1: +\n2: -\n3:*\n4: /\n");
            op= int.Parse(Console.ReadLine());      

            //ifs e elses da op:

            if ( op== 1)
            {
              result=  a + b;
                Console.WriteLine("O valor da soma é: ");    
                Console.Write(result);
            }
            if(op==2)
            {
                result= a - b;
                Console.WriteLine("O valor da subtração é: ");
                Console.Write(result);

            }
            if(op == 3)
            {
                result = a * b;
                Console.WriteLine("O valor da multiplicação é:");
                Console.Write(result);

            }
            if(op == 4)
            {
                result = a / b;
                Console.WriteLine("O valor da divisão é: ");
                Console.Write(result);

            }
            else
            {
                Console.WriteLine("Valor não identificado");
            }

            Console.WriteLine("Muito obrigado pela atenção");
            Console.WriteLine("fim");




        Console.ReadLine();
    }
}
}
