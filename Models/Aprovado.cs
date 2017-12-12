using System;

namespace Xperiments.DesignPatterns.State.Models
{
        
    public class Aprovado : EstadoDeUmOrcamento
    {
       
        public void AplicaDescontoExtra(Orcamento orcamento) => orcamento.Valor -= (orcamento.Valor * 0.02);

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado.");
            
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento aprovado não pode ser reprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

    }
}