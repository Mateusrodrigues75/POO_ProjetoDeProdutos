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
            novaMarca.Codigo = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o nome da Marca: ");
            novaMarca.NomeMarca = Console.ReadLine();
            
            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);
            return novaMarca;
        }

        public void Listar(){
            Console.WriteLine($"Marcas Cadastradas: ");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Código: {item.Codigo}");   
            }
            
        }

        public void Deletar(int cod){
            Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(marcaDelete);
        }
    }
}