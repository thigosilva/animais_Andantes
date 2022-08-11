using System;
using System.Collections.Generic;
using System.Text;

namespace animais_Andantes
{
    public class Gatos_Cacho
    {

        public void anda(int passo)
        {

            for (int i = 0; i < passo; i++)
            {
                Console.WriteLine("Passos executados" + i.ToString());
            }
        }
    }
  
}
