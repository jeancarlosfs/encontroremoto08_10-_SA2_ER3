
namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaFisica novaPf = new PessoaFisica();
            Endereco end = new Endereco();
            end.logradouro = "Rua Guanabara";
            end.numero = 300;
            end.complemento = "Próximo a sorveteria";
            end.enderecoComercial = false;

            novaPf.endereco = end;
            novaPf.cpf = "123456789";
            novaPf.nome = "Jean Carlos";
            novaPf.dataNascimento = new DateTime(1998,07,13);

            Console.WriteLine(@$"Rua: {end.logradouro},{end.numero}");

            bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);
            
            if (idadeValida)
            {
                Console.WriteLine($"Cadastro Aprovado");
                
            }else`{
                Console.WriteLine($"Cadastro Reprovado");
            }
              

        }
    }
}
