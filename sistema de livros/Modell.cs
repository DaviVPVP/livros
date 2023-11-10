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
        public int resposta;
        public string contato;
        public int opcao;

        public Model()
        {
            FazerReserva = -1;
        }

        public int FazerReserva
        {
            get { return this.opcao; }
            set { this.opcao = value; }
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
                Console.WriteLine("CADASTRO CONCLUÍDO!");

                Console.WriteLine("Informe seu login: ");
                if (Console.ReadLine() != login)
                do
                  {
                      {
                        Console.WriteLine("Usuário não identificado! \n " +
                            "Informe seu login: ");
                      }
                   } while (Console.ReadLine() != login);

                Console.WriteLine("Informe sua senha: ");
                if (Console.ReadLine() != senha)
                    do
                    {
                        {
                            Console.WriteLine("Senha incorreta! \n " +
                                "Informe sua senha: ");
                        }
                    } while (Console.ReadLine() != senha);

                Console.WriteLine("Seja Bem vindo(a)!");
            }
        }

        //OPÇÃO DE LIVROS

        public void Reserva()
        {
            Console.WriteLine("Livro indisponível ): Gostaria de fazer a reserva do livro? \n" +
                              "1. Sim \n" +
                              "2. Não \n");
            FazerReserva = Convert.ToInt32(Console.ReadLine());

            switch (FazerReserva)
            {
                case 1:
                    Console.WriteLine("Informe seu e-mail ou número de telefone: ");
                    contato = Console.ReadLine();

                    Console.WriteLine("Você será notificado(a) quando este livro ou livros estiverem disponíveis! \n");
                    break;
                case 2:
                    break;
            }
        }

    }
}