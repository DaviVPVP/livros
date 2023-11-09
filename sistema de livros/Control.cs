using sistema_de_livros;
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

        public Control()
        {
            this.modelo = new Model();//Criando uma chave            
            ConsultarOpcao = -1;
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "0. Sair\n" +
                              "1. Login\n" +
                              "2. Escolher livro\n" +
                              "3. Efetuar compra\n");
            opcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do menu

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
                    this.modelo.books();
                    break;
                case 2:
                    this.modelo.books();
                    break;
                case 3:
                    this.modelo.books();
                    break;
            }//fim do switch









        }//fim de operacao
    }
}