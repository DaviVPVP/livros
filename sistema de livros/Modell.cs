using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaLivros
{
    class Model
    {
        public string login;
        public string senha;
        public string nome;
        public string endereco;
        public string telefone;
        public string nascimento;
        public int book;
        public int opsao;
        public int resposta;

        public Model()
        {
            ConsultarOpsao = -1;
        }

        public void loginSenha()
        {
            Console.WriteLine("Você já possui cadastro? \n1. Sim\n2. Não");
            resposta = Convert.ToInt32(Console.ReadLine());
            if (resposta == 1)
            { 
                Console.WriteLine("Informe seu login: ");
                login = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe sua senha: ");
                senha = Convert.ToString(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Informe seu nome: ");
                nome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe seu endereço: ");
                endereco = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe seu telefone: ");
                telefone = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe sua data de nascimento: ");
                nascimento = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe seu login: ");
                login = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe sua senha: ");
                senha = Convert.ToString(Console.ReadLine());
            }
        }

        //OPÇÃO DE LIVROS
        public int ConsultarOpsao
        {
            get { return this.opsao; }
            set { this.opsao = value; }
        }
        public void books()
        {
            Console.WriteLine("Escolha um dos livros abaixo: \n\n" +
                "0. Sair \n" +
                "1. Harry Potter \n" +
                "2. Senhor dos Anéis \n" +
                "3. Percy Jackson \n");
            opsao = Convert.ToInt32(Console.ReadLine());
        }
        public void operacao3()
        {
            books();//mostrar as opçoes de livros em tela
            switch (ConsultarOpsao)
            {
                case 0:
                    Console.WriteLine("Obrigado!");
                    break;
                case 1:
                    Console.WriteLine("Harry Potter");
                    break;
                case 2:
                    Console.WriteLine("Senhor dos Anéis");
                    break;
                case 3:
                    Console.WriteLine("Percy Jackson");
                    break;
                case 4:
                    Console.WriteLine();
                    break;
            }
        }












    }
}