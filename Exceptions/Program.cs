var arr = new int[3];

try
{
    // for (var index = 0; index<10; index++)
    // Console.WriteLine(arr[index]);
    Salvar("");
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o indice na lista");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);

}
catch(MinhaException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.QuandoAconteceu);
    Console.WriteLine("Exceção customizada");

}

catch(Exception ex)
{
    Console.WriteLine("Algo errado");
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);

}
finally
{
    Console.WriteLine("Chegou ao fim!");// Sempre passa no finaly, como erro ou não
}



static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new ArgumentNullException("O texto não pode ser nulo");
                //throw new Exception("O texto não pode ser nulo");
                throw new MinhaException(DateTime.Now);
        }       


public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set; }
        }




