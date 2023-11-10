using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaLivros
{
    class Control
    {
        Model modelo;
        public int opcao;
        public int opsao;
        public int carrinho;

        public Control()
        {
            this.modelo = new Model();//Criando uma chave            
            ConsultarOpcao = -1;
            ConsultarOpsao = -1;
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }

        public int ConsultarOpsao
        {
            get { return this.opsao; }
            set { this.opsao = value; }
        }

        public void Menu()
        {
            Console.WriteLine("Faça login para prosseguir: \n\n" +
                              "0. Sair\n" +
                              "1. Login\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do menu

        public void books()
        {
            Console.WriteLine("Escolha o(s) livro(s) de sua preferência: \n\n" +
                "0. Sair \n" +
                "1. Harry Potter (R$ 30,00) \n" +
                "2. Senhor dos Anéis (R$ 40,00) \n" +
                "3. Percy Jackson (R$ 35,00) \n" +
                "4. Animal Planet (R$ 30,00) \n" +
                "5. Prosseguir com o pagamento\n ");
            ConsultarOpsao = Convert.ToInt32(Console.ReadLine());
        }

        public void Operacao()
        {

            Menu();//Mostrar o menu em tela
            switch (ConsultarOpcao)
            {
                case 0:
                    Console.WriteLine("Obrigado!");
                    break;
                case 1:
                    this.modelo.loginSenha();
                    do
                    {
                        books();//mostrar as opçoes de livros em tela
                        switch (ConsultarOpsao)
                        {
                            case 0:
                                Console.WriteLine("Obrigado!");
                                break;
                            case 1:
                                Console.WriteLine("Harry Potter adicionado ao carrinho!");
                                carrinho += 30;
                                break;
                            case 2:
                                Console.WriteLine("Senhor dos Anéis adicionado ao carrinho!");
                                carrinho += 40;
                                break;
                            case 3:
                                this.modelo.Reserva();
                                break;
                            case 4:
                                this.modelo.Reserva();
                                break;
                            case 5:
                                Console.WriteLine("O valor total é de R$ " + carrinho);
                                break;
                            default:
                                Console.WriteLine("Escolha uma opção válida!");
                                break;
                        }
                    } while (ConsultarOpsao != 0 && ConsultarOpsao != 5);  
                    break;

            }
        }
    }
}