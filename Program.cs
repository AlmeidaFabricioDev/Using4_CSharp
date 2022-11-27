namespace Utilizando_using4_em_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\temp\arquivo1.txt"; //Aqui pego no diretório local o arquivo que irei trabalhar

            try //Aqui utilizamos o try para testar pontos críticos do código, ou seja, lugares que onde há grande possibilidade de erros
            {
                //Using fecha o objeto arquivo depois do seu uso
                using (FileStream arquvo = new FileStream(caminho, FileMode.Open))
                //FileStream forncece um stream para o arquivo, e o Filemode.open abre um  arquivo do tipo FileStream
                {
                    //Using fecha o objeto leitor depois de seu uso uso
                    using (StreamReader leitor = new StreamReader(arquvo))
                    //SreamReader fará a leitura deste arquivo
                    {
                        string linhas = leitor.ReadLine(); //Se tudo ocorrer bem, linhas do tipo string irá receber o leitor que é do tipo StreamReader.
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
