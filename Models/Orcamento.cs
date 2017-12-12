using System;
using System.Collections.Generic;

namespace Xperiments.DesignPatterns.State.Models
{

    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        
        private bool AplicouDescontoAdicional { get; set; }

        public List<Item> Itens { get; private set;}

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }
        
        public void AplicaDescontoExtra()
        {
            if(AplicouDescontoAdicional)
                throw new Exception("Desconto extra já aplicado");
            
            this.EstadoAtual.AplicaDescontoExtra(this);
            AplicouDescontoAdicional = true;
        
        }

        public void AdicionaItens(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            this.EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            this.EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            this.EstadoAtual.Finaliza(this);
        }

    }


}


