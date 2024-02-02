using System;

namespace Fatorial{
    class ContaFatorial{
        static void Main(){
            
            Console.WriteLine("bem vindo ao app de Calculo de Fatorial");

            Console.WriteLine("DIGITE UM NUMERO INTEIRO E POSITIVO");

            string num = Console.ReadLine();

            long numConvert = Convert.ToInt32(num);

            
            
            long numProIndex = numConvert - 1;
            int numProIndex2 = Convert.ToInt32(numProIndex);

            //esta multiplicando até que chegue igual a um 
            for(int index = numProIndex2; index > 0 ; index --){

                //resultado da soma anterior
                long resultado =  numConvert * index;
                numConvert = resultado;

                
            }
            Console.WriteLine(numConvert);
        }
    }
}