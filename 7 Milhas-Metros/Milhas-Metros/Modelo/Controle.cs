using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milhas_Metros.Modelo
{
    public class Controle: absPropriedades
    {
        public Controle(String milhas) : base(milhas)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            absPropriedades validacao = new Validacao(this.milhas);
            
            if(validacao.mensagem.Equals(""))
            {
                absPropriedades conversor = new Conversor(validacao.numeroMilhas);
                this.resposta = conversor.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            
        }
    }
}
