/*
 Sequência de escape de caractere. 
 As sequências de caracteres de escape começam com a uma barra invertida \
*/
/* comentando para não ficar muita coisa no console
Console.WriteLine("Adicionando quebra de linha e espaço em branco:");
Console.WriteLine("Hello\nWorld!"); // \n vai adicionar uma nova linha em sequência
Console.WriteLine("Hello\tWorld!"); // \t adidionará uma guia

Console.WriteLine(""); // Apenas para pular uma linha no console

// Para inserir aspas duplas no terminal, precisa colocar a barra invertida antes dessa forma: \"
Console.WriteLine("Inserindo aspas dupla no console:");
Console.WriteLine("Hello \"World\"!");

Console.WriteLine("");// Apenas para pular uma linha no console

// Para inserir caminho de arquivo no console, precisa inserir duas barras invertida \\ já que uma barra é designado para sequência de escape
Console.WriteLine("Inserindo caminho de arquivo:");
Console.WriteLine("c:\\source\\repos");
*/
/*
 Etapa 1 - Formatar a sáida o aplicativo de linha de comando usando sequências de escape de caractere
*/
/*
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoices: 1021\t\tComplete!");
Console.WriteLine("Invoices: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
*/
/*
 Literal de cadeia de caracteres textual
*/
/*
Console.WriteLine("Inserindo caracteres e espaços em branco sem barra invertida:");
Console.WriteLine(@"    c:\source\repos
        (""this is where your code goes"")");
*/
/* 
 Etapa 2 - formtar a saída do aplicativo de linha de comando usando uma cadeia de caracteres textual
*/
/* 
Console.WriteLine("Inserindo cadeia de caracteres textual");
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoices: 1021\t\tComplete!");
Console.WriteLine("Invoices: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices"); 
*/
/*
 Caracteres de escaoe Unicode
*/
/* 
Console.WriteLine("Inserindo caracteres especiais usando sequencia de escape:");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World");
*/
