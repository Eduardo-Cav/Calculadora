using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perguntar a operação
            Console.WriteLine("Qual operação deseja realizar? \nSoma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            //Pedir o primeiro número
            Console.WriteLine("Digite o 1° número: ");
            float num1 = float.Parse(Console.ReadLine());

            //Pedir o segundo número
            Console.WriteLine("Digite o 2° número: ");
            float num2 = float.Parse(Console.ReadLine());

            //Cálculo
            float resultado = 0f;

            // if(operacao == "Soma")
            // {
            //     resultado = num1 + num2;
            // }
            // else if(operacao == "Subtracao"){
            //     resultado = num1 - num2;
            // }
            // else if(operacao == "Multiplicacao"){
            //     resultado = num1 * num2;
            // }
            // else if(operacao == "Divisao"){
            //     resultado = num1 / num2;
            // }
            // else{
            //     Console.WriteLine("Operação inválida.");
            // }


            switch(operacao){
                
                case "Soma":
                    resultado = num1 + num2;
                    break;
                
                case "Subtracao":
                    resultado = num1 - num2;
                    break;
                
                case "Multiplicacao":
                    resultado = num1 * num2;
                    break;
               
                case "Divisao":
                    resultado = num1 / num2;
                    break;

                default:
                operacao = "invalida";
                Console.WriteLine("Operacao inváida");
                break;
            }

           
            if(operacao != "invalida1'")
            //Concatenação
            Console.WriteLine($"Cálculo: {num1} com {num2} é igual a {resultado}");

        }
    }
}
