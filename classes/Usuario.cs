
using System;

namespace POO_ProjetoDeProdutos.classes
{
    public class Usuario
    {
        public Usuario()
        {
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha, DateTime _dataCadastro)
        {
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }

        public int Codigo { get; set; }         
        public string Nome { get; set; }    
        public string Email { get; set; }   
        public string Senha { get; set; }   
        public DateTime DataCadastro { get; set; } 

        public void Cadastrar(){
            Nome = "Mateus";
            Email = "admin@admin.com";
            Senha = "12345";
            DataCadastro = DateTime.UtcNow;
        }       

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");

        }
         
        


    }
}