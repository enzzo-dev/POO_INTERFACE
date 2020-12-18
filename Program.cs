using System;
using System.Collections.Generic;
using POO_INTERFACE.classes;

namespace POO_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            Produto p1 = new Produto();

            System.Console.WriteLine("Deseja adicionar quantos produtos? ");
            int resposta1 = int.Parse(Console.ReadLine());

            int i = 0;
            do{
                Produto p2 = new Produto();
                System.Console.WriteLine($"Digite o nome do {i+1}° produto: ");
                p2.Nome = Console.ReadLine();

                System.Console.WriteLine($"Digite o código de identificação do {i+1}° produto: ");
                p2.Codigo = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"Digite o preço do {i+1}° produto: ");
                p2.Preco = float.Parse(Console.ReadLine());

                carrinho.Cadastrar(p2);

                i++;
            } while(i < resposta1);

             carrinho.Listar();

             System.Console.WriteLine("Deseja remover algum produto? [1] - Sim / [2] - Não");
             int resposta2 = int.Parse(Console.ReadLine());

             if(resposta2 == 1){

                 Produto excluir = new Produto();
                 System.Console.WriteLine("Qual produto você deseja deletar? Digite o código de identificação: ");
                 excluir.Codigo = int.Parse(Console.ReadLine());

                 carrinho.Deletar(excluir.Codigo);

                 carrinho.Listar();
             }
        }
    }
}
