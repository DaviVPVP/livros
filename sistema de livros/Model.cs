using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_livros
{
    class Model
    {
        public string[] nome;
        public string[] endereco;
        public string[] telefone;
        public string[] nascimento;
        public string[] login;
        public string[] senha;

        public Model() 
        {
            nome = new string[3];
            endereco = new string[3];
            telefone = new string[3];
            nascimento = new string[3];
            login = new string[3];
            senha = new string[3];
        }
        
        public void cadastrarUsuario()
        {
            Console.WriteLine("Informe seu nome: ");
            nome[3] = Console.ReadLine();

            Console.WriteLine("Informe seu endereço: ");
            endereco[3] = Console.ReadLine();

            Console.WriteLine("Informe seu telefone: ");
            telefone[3] = Console.ReadLine();

            Console.WriteLine("Informe sua data de nascimento; ");
            nascimento[3] = Console.ReadLine();

            Console.WriteLine("Informe o seu login: ");
            login[3] = Console.ReadLine();

            Console.WriteLine("Informe a sua senha: ");
            senha[3] = Console.ReadLine();













        }



            

            
            
            
       

        
    }
}
