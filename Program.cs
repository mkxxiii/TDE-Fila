
namespace TDE
{
	public class Program
	{
        static FilaDinamica filaPrefencial;
        static FilaDinamica filaComum; 

        static void Main(string[] args)
        {
            filaPrefencial = new FilaDinamica();
            filaComum = new FilaDinamica();
            Menu();
        }

        static void PrintarMenu(){
            Console.WriteLine("**********************************");
            Console.WriteLine("* Bem vindo ao TDE de Filas!     *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("* 1 - Gerar Senha Preferencial   *");
            Console.WriteLine("* 2 - Gerar Senha Comum          *");
            Console.WriteLine("* 3 - Consultar Senhas           *");
            Console.WriteLine("* 4 - Chamar Senha Prefencial    *");
            Console.WriteLine("* 5 - Chamar Senha Comum         *");
            Console.WriteLine("* 9 - Sair                       *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("**********************************");
        }


        static void Menu(){
            int opcao;
            do
            {
                PrintarMenu();
                Console.Write("Digite a ação desejada: ");
                if(int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao){
                        case 1:
                            GerarSenhaPreferencial();
                            break;
                        case 2:
                            GerarSenhaComum();
                            break;
                        case 3:
                            ConsultarSenhas();
                            break;
                        case 4:
                            ChamarSenhaPreferencial();
                            break;
                         case 5:
                            ChamarSenhaComum();
                            break;
                        case 9:
                            break;
                        default:
                            Console.WriteLine("Valor inválido! Digite um valor valido");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um valor valido");
                }

                Console.WriteLine("Digite ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            } while(opcao != 9);

            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();
        }

        static void GerarSenhaPreferencial(){
            Console.WriteLine("Senha P gerada");
        }

        static void GerarSenhaComum(){
            Console.WriteLine("Senha C gerada");
        }

        static void ConsultarSenhas(){
            Console.WriteLine("Senha Consultada");
        }

        static void ChamarSenhaPreferencial(){
            Console.WriteLine("Senha P chamada");
        }

        static void ChamarSenhaComum(){
            Console.WriteLine("Senha C chamada");
        }

    }

}


/*
Regras:
1 - Caso você clique no botão e a fila esteja vazia a mensagem de fila vazia deve ser exibida.
2 - Nome Senha Prefencial (CXP-001)
3 - Nome Senha Comum (CXN-001)
4 - Na consulta de Senhas deve ser exibido a atual e a proxima de cada fila
*/

