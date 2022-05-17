var id = Guid.NewGuid(); //Identificador único
id.ToString(); //Método que transforma o Guid em uma string


id = new Guid("a0d5affc-28d3-4b3d-99b7-035a756f68a1");

//Console.WriteLine(id.ToString().Substring(0,8));

if(id != Guid.NewGuid())
    Console.WriteLine(id.ToString().Substring(0,8));

//id = new Guid(); // Gera Guid com zeros
//Console.WriteLine(id);
