using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milhas_Metros.Modelo
{
    public abstract class absPropriedades: intMetodos
    {
        public String mensagem;
        public String resposta;
        public String milhas;
        public Double numeroMilhas;

        public absPropriedades(String milhas)
        {
            this.milhas = milhas;
        }

        public absPropriedades(Double numeroMilhas)
        {
            this.numeroMilhas = numeroMilhas;
        }

        public virtual void Executar()
        {
        }

        public override string ToString()
        {
            return this.resposta;
        }

    }
}
