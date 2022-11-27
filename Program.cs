namespace Utilizando_using4_em_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\temp\arquivo1.txt"; //Aqui pego no diretório local o arquivo que irei trabalhar


            try //Aqui utilizamos o try para testar pontos críticos do código, ou seja, lugares que onde há grande possibilidade de erros
            {
                //Using vai fechar o objeto depois do seu uso
                //O leitor do tipo stream reader vai receber o arquivo caminho dentro do método File.OpenText que fará a leitura deste arquivo
                using (StreamReader leitor = File.OpenText(caminho))
                {
                    while (!leitor.EndOfStream) //Enquanto a o leitor na posição do fluxo atual Não(!) estiver no final executa a estrutura de repetição abaixo
                    {
                        string linhas = leitor.ReadLine(); //linhas do tipo string irá receber o leitor que é do tipo StreamReader
                        Console.WriteLine(linhas); //Aqui ocorrerá a impressão na tela do console.
                    }
                }
            }
            catch (IOException e) //Caso ocorra alguma exceções geradas ao acessar informações usando fluxos, arquivos e diretórios.
            {
                Console.WriteLine("Ocorreu um erro!"); //Está mensagem personalizada será impressa no console
                Console.WriteLine(e.Message); //Aqui o console irá mostrar a exceção pelo sistema em relação ao arquivo.
            }

        }
    }
}
