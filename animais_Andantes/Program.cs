using System;
using animais_Andantes;


namespace animais_Andantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Gatos_Cacho H = new Gatos_Cacho();
         RETORNO_ERRO:
            Console.WriteLine(" Digite o Animal que deseja:");
            string animais = Console.ReadLine();
            if(animais.ToUpper() == "GATO" || animais.ToUpper() == "CACHORRO" || animais.ToUpper() == "CAVALO")
            {
                
            }
            else
            {
                Console.WriteLine("ERRO DIGITE NOVAMENTE");
                Console.WriteLine("!! GATO, CACHORRO, CAVALO !! ");
                goto RETORNO_ERRO;
            }

        ROTORNO_PASSOS:
            Console.WriteLine("Digite a Quantidade de Passos: ");
            string passos = Console.ReadLine();
            if (passos == "1" || 
                passos == "2" || 
                passos == "3" || 
                passos == "4" || 
                passos == "5" || 
                passos == "6")
            {
                H.anda(int.Parse(passos));
            }
            else
            {

                Console.WriteLine("=====> O" + animais + "Esta Dando" + passos + " a Frente" ); 


                goto ROTORNO_PASSOS;
            }
        

        }
    }
}
