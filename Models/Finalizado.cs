using System;

namespace Xperiments.DesignPatterns.State.Models
{
        
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => throw new System.Exception("Orçamentos finalizados não recebem desconto.");

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado, não pode mais ser aprovado.");
            
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado, não pode mais ser reprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado, não pode mais ser finalizado.");
        }

    }
}