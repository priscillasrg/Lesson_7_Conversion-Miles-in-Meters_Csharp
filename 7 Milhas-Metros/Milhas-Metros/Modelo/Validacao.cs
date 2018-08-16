using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milhas_Metros.Modelo
{
    public class Validacao: absPropriedades
    {
        public Validacao(String milhas): base(milhas)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.numeroMilhas = Convert.ToDouble(this.milhas);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro de conversão";                
            }
        }       
    }
}
