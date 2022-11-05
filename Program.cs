using Back_ER02.classes;

PessoaFisica NPF = new PessoaFisica();
Endereco NEndFisico = new Endereco();
PessoaJuridica PJN = new PessoaJuridica();

NPF.nome = "Brenda";
NPF.cpf = "25698460739"; 
NPF.rendimento = 6600.5f;
NPF.dataNasc = new DateTime(2000, 05, 06);
NPF.endereco = NEndFisico;

NEndFisico.logradouro = "Rua elisberto cunha";
NEndFisico.numero = 36;
NEndFisico.complemento = "ffffff";
NEndFisico.endComercial = true;

Console.WriteLine(@$"
Olá, {NPF.nome}! 
CPF: {NPF.cpf}
Data de Nascimento: {NPF.dataNasc}
Logradouro: {NPF.endereco.logradouro} {NPF.endereco.numero} {NPF.endereco.complemento}
seu rendimento é de: {NPF.rendimento}");


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





 