using System.Globalization;

Console.Clear();

decimal valor = 10.25m; //Primeira opção pra trabalhar com moedas é decimal

// Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
// Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formata generico
// Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formata com a moeda do local escolhido
// Console.WriteLine(String.Format("{0:C}", valor)); // Formata pra o tipo C
// Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
// Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formata com precisão maior
// Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"))); // Fomara com numero
// Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formata porcentagem

Console.WriteLine(Math.Round(valor)); // Arredonda na média
Console.WriteLine(Math.Ceiling(valor)); // arredonda pra 
Console.WriteLine(Math.Floor(valor)); // arredonda pra baixo