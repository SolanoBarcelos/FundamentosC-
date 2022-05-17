
var texto = "testando";
Console.WriteLine(texto.CompareTo("testando"));// retorna 0 pois e true
Console.WriteLine(texto.CompareTo("Testando"));// retorna 1 pois e falso

Console.WriteLine(texto.Contains("teste"));
Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));

