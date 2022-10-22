using Back_ER02.classes;

PessoaFisica NPF = new PessoaFisica();

NPF.nome = "Brenda";
NPF.cpf = "25698460739"; 
NPF.rendimento = 6600.5f;

//Console.WriteLine($"Olá,  {NPF.nome}! seu CPF: {NPF.cpf}");

//pessoa fisica ER03--------
float impostoPagar = NPF.CalcularImposto (NPF.rendimento); 
Console.WriteLine($"{impostoPagar:0.00}" );
Console.WriteLine(impostoPagar.ToString("C") );

//pessoa juridica ER03------- 
PessoaJuridica NPJ = new PessoaJuridica();
Console.WriteLine(NPJ.CalcularImposto(6600.5f));


 