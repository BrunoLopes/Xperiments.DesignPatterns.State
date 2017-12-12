using System;

namespace Xperiments.DesignPatterns.State.Models
{
        
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => throw new System.Exception("Orçamentos reprovados não recebem desconto.");            


        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado, não pode ser aprovado.");
            
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

    }
}