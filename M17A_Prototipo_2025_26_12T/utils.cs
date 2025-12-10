using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T
{
    internal class utils
    {
        /// <summary>
        ///  Verifica se a pasta existe, se não existir cria a pasta
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns>Caminho completo para a pasta(sem\ no final)</returns>
        static public string PastaProgram(string Nome)  
        {
          string pastainicial= Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pastainicial +=@"\"+ Nome;
            if (System.IO.Directory.Exists(pastainicial) == false)
                System.IO.Directory.CreateDirectory(pastainicial);
            return pastainicial;

        }
    }
}
