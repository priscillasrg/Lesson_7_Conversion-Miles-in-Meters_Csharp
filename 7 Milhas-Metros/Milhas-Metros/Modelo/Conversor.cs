using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milhas_Metros.Modelo
{
    public class Conversor: absPropriedades
    {
        public Conversor(Double numeroMilhas) : base(numeroMilhas)
        {
            Executar();
        }

        public override void Executar()
        {
            // 1 milha = 1609.34 metros

            this.numeroMilhas = numeroMilhas * 1609.34;
            this.resposta = ("O valor convertido em metros é de: \n \n" + numeroMilhas.ToString("#0.00"));
        }
    }
}
