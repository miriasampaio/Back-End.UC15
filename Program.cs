using Back_ER02.classes;

internal class Program
{
    private static void Main(string[] args)
    {
        List<PessoaFisica> listPf = new List<PessoaFisica>();
        Console.Clear();

        utils.BarraCarregamento("carregando ");

        string? opcao;
        do
        {

            Console.ResetColor();

            Console.WriteLine(@$"

 __________________________________
|       Sistema de Cadastro        |
| para Pessoas Fisicas E Juridicas |
|__________________________________|
|                                  |
|        1 Pessoa Fisica           |
|        2 Pessoa Juridica         |
|        0 Sair                    |
|__________________________________|
 ");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                string? opcaoPF;
                do
                {
                    Console.Clear();
                    Console.WriteLine(@$"
 _______________________________
|    Escolha uma opção abaixo   |
|_______________________________|
|  1 Cadastrar Pessoa Fisica    |
|  2 Listar Pessoa Fisica       |
|                               |
|  0 Retornar ao menu           |
|_______________________________|");
                 
            opcaoPF = Console.ReadLine();

             switch (opcaoPF)
            {
                case "1":
                    PessoaFisica NPF = new PessoaFisica();
                    Endereco NEndFisico = new Endereco();

                    Console.WriteLine($"Digite o nome da pessoa fisica");
                    NPF.nome = Console.ReadLine();

                    bool dataValida;

                 do
                 {
                    Console.WriteLine($"Digite data de nascimento DD/MM/AAAA");
                    string? dataNascimento = Console.ReadLine();

                    dataValida = NPF.ValidarDataNasc(dataNascimento);
                     if (dataValida)
                     {
                        DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                        NPF.dataNasc = dataConvertida;
                     } else {

                        Console.WriteLine("Data inválida. Digite corretamente DD/MM/AAAA");
                        Thread.Sleep(3000);
                     }
                } while (dataValida == false); //repertir

                    Console.WriteLine($"Digite o número de CPF");
                    NPF.cpf = Console.ReadLine();

                    Console.WriteLine($"Digite o valor de rendimento mensal *Apenas números* ");
                    NPF.rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o logradouro");
                    NEndFisico.logradouro = Console.ReadLine();

                    Console.WriteLine($"Digite o número");
                    NEndFisico.numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o complemento");
                    NEndFisico.complemento = Console.ReadLine();

                    Console.WriteLine($"Este endereço é comercial? *S/N");
                    string? endCom = Console.ReadLine().ToUpper();

                      if (endCom == "S")
                      {
                          NEndFisico.endComercial = true;
                      }
                      else
                      {
                          NEndFisico.endComercial = false;
                      }

                    NPF.endereco = NEndFisico;

                    listPf.Add(NPF);
                        break;

                        case "2":
                        Console.Clear();

                        if (listPf.Count > 0)
                        {
                            
                        foreach (PessoaFisica cadaP in listPf)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                            Nome: {cadaP.nome}
                            Endereço: {cadaP.endereco.logradouro}, {cadaP.endereco.numero}
                            Data de Nascimento: {cadaP.dataNasc.ToString("d")}
                            imposto a pagar: {cadaP.CalcularImposto(cadaP.rendimento).ToString("C")}
                            
                            ") ;

                            Console.WriteLine($"Aperte ENTER para prosseguir");
                            Console.ReadLine();
                        }
                        } else {
                             Console.Clear();
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine($"Opção inválida, lista vazia. Cadastre uma nova Pessoa Fisica");
                     Console.ResetColor();
                     Thread.Sleep(2500);
                        }
                         break;

                        case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltando ao menu...");
                        Thread.Sleep(1500);
                        break;

                    default:
                     Console.Clear();
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine($"Opção inválida");
                     Console.ResetColor();
                     Thread.Sleep(2500);
                        break;
                  }
                  
                  //Console.WriteLine(opcaoPF);
                  //Thread.Sleep (1500);

                } while (opcaoPF != "0");
            break;

                    //Console.WriteLine($"Pessoa Fisica");

                   // NPF.nome = "Brenda";
                   // NPF.cpf = "25698460739";
                   // NPF.rendimento = 6600.5f;
                   // NPF.dataNasc = new DateTime(2000, 05, 06);
                   // NPF.endereco = NEndFisico;
                    //NEndFisico.logradouro = "Rua elisberto cunha";

                   // NEndFisico.numero = 36;
                    //NEndFisico.complemento = "ffffff";
                   // NEndFisico.endComercial = true;
//
                   // Console.WriteLine(@$"
       // Olá, {NPF.nome}! 
       // CPF: {NPF.cpf}
       // Data de Nascimento: {NPF.dataNasc}
       // Logradouro: {NPF.endereco.logradouro} {NPF.endereco.numero} {NPF.endereco.complemento}
       //Seu rendimento é de: {NPF.rendimento}");

                    //Thread.Sleep(4000);
                   // break;
                case "2":
                    Console.WriteLine($"Pessoa Juridica");

                    PessoaJuridica PJN = new PessoaJuridica();
                    Endereco novoEndPj = new Endereco();

                    PJN.nome = "Nome Pessoa Juridica";
                    PJN.razaoSocial = "Razão Socia PJ";
                    PJN.cnpj = "00.476.645/0001-03";

                    novoEndPj.logradouro = "Rua Niteroi";
                    novoEndPj.numero = 180;

                    PJN.endereco = novoEndPj;

                    Console.WriteLine(@$"
        Nome: {PJN.nome}
        Razão Social: {PJN.razaoSocial}
        CNPJ: {PJN.cnpj} - Valido: {PJN.ValidarCnpj(PJN.cnpj)}
        ");

                    Console.WriteLine("Aperte Enter para sair");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine($".");
                    break;

                default:
                    Console.WriteLine($"Opção inválida");
                    break;
            }

        } while (opcao != "0");

        utils.BarraCarregamento("finalizando ");
    }
}
















//--------------------------------------------------------------------------------------------------
//Console.WriteLine($"Olá,  {NPF.nome}! seu CPF: {NPF.cpf}");

//pessoa fisica ER03--------
//float impostoPagar = NPF.CalcularImposto (NPF.rendimento); 
//Console.WriteLine($"{impostoPagar:0.00}" );
//Console.WriteLine(impostoPagar.ToString("C") );

//pessoa juridica ER03------- 
//PessoaJuridica NPJ = new PessoaJuridica();
//Console.WriteLine(NPJ.CalcularImposto(6600.5f));

//validação de data em DateTime *TH = Tempo e Hora
///DateTime TH = new DateTime (2005, 01, 01);
//Console.WriteLine(NPF.ValidarDataNasc("05/06/2004"));  





