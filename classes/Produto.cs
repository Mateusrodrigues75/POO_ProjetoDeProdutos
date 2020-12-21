using System;
using System.Collections.Generic;

namespace POO_ProjetoDeProdutos.classes
{
    public class Produto
    {
        public int Codigo { get; set; } 
        public string NomeProduto { get; set; } 
        public float Preco { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }  
        List<Produto> ListaDeProduto = new List<Produto>();

        public void Cadastrar(){
            Produto novoProduto = new Produto();
            Console.WriteLine($"Digite o código do Produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite o nome do Produto: ");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Digite o código do Produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;

            novoProduto.Marca = Marca.CadastrarMarca();
            novoProduto.CadastradoPor = new Usuario();
            ListaDeProduto.Add(novoProduto);
            
        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (Produto item in ListaDeProduto)
            {
                System.Console.Write($"Código: {item.Codigo}");
                System.Console.Write($"Nome: {item.NomeProduto}");
                System.Console.Write($"Preço: {item.Preco}");
                System.Console.Write($"Data do Cadastro: {item.DataCadastro}");
                System.Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                System.Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
                System.Console.WriteLine();
            }
            Console.ResetColor();
        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProduto.Find(p => p.Codigo == cod);
            ListaDeProduto.Remove(prodDelete);
        }
    }
}