using System;
using System.Collections.Generic;

namespace POO_ProjetoDeProdutos.classes
{
    public class Marca
    {
        public int Codigo { get; set; } 
        public string NomeMarca { get; set; }   
        public DateTime DataCadastro { get; set; }  
        public List<Marca> Marcas = new List<Marca>();

        public Marca CadastrarMarca(){
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite o código da Marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o nome da Marca: ");
            novaMarca.NomeMarca = Console.ReadLine();
            
            novaMarca.DataCadastro = DateTime.Now;

            Marcas.Add(novaMarca);
            return novaMarca;
        }

        public void Listar(){
            Console.Clear();
            Console.WriteLine($"Marcas Cadastradas: ");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.NomeMarca}");
                Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");   
            }
            
        }

        public void Deletar(int cod){
            Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(marcaDelete);
        }
    }
}