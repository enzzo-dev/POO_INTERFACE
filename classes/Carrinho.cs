using System;
using System.Collections.Generic;

namespace POO_INTERFACE.classes
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int cod, Produto produto)
        {
           //Lambda
           carrinho.Find(x => x.Codigo == cod).Nome = produto.Nome;
           carrinho.Find(x => x.Codigo == cod).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(int codigo)
        {
           var prod = carrinho.Find( x => x.Codigo == codigo); 
           carrinho.Remove(prod);
        }

        public void Listar()
        {
            foreach (Produto itemCarrinho in carrinho)
            {
                Console.WriteLine($"Produto: {itemCarrinho.Nome}\nPreço: R$ {itemCarrinho.Preco}\nCódigo: {itemCarrinho.Codigo}");
            }
        }
    }
}