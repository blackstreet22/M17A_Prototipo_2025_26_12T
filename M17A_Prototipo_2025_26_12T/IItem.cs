using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T
{
    internal interface IItem
    {
        //Validar Dados
        List<string> validar();

        //Adicionar
        void Adicionar();

        //Editar
        void editar();

        //Apagar
        void apagar();
    }
}
