using System;

namespace mcbonalds{
    
    public class Cliente{
        public string Nome {get; set;}
        public string Endereco{get; set;}
        public string Telefone{get; set;}
        public string Senha{get; set;}
        public string Email{get; set;}
        public DateTime DataNascimento{get; set;}


        //Construtor

        public Cliente(string nome, string Telefone, string Email){
            this.Nome = nome; 
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}