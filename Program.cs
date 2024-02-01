using System;

namespace Fatorial{
    class ContaFatorial{
        static void Main(){
            
            Console.WriteLine("bem vindo ao app de Calculo de Fatorial");

            Console.WriteLine("DIGITE UM NUMERO INTEIRO E POSITIVO");

            string num = Console.ReadLine();

            int numConvert = Convert.ToInt32(num);
            
            int numProIndex = numConvert - 1;

            //esta multiplicando até que chegue igual a um 
            for(int index = numProIndex; index > 0 ; index --){

                //resultado da soma anterior
                int resultado =  numConvert * index;
                numConvert = resultado;

                Console.WriteLine(numConvert);
            }
        }
    }
}