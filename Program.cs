const string SenhaCorreta = "dasvi1409";
string senha, permissaoAcesso;

Console.Write ("Olá usuário. Por favor Digite sua senha: ");
senha = Console.ReadLine();

permissaoAcesso = senha == SenhaCorreta ? "permitido" : "negado";

Console.WriteLine($"Acesso {permissaoAcesso} ");


