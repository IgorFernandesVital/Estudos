/* 
 Etapa 1 - Usar a interpolação de cadeia de caracteres para combinar uma cadeia de caracteres literal e um valor variável.
*/
/* 
string firstName = "Bob";
string massage = $"Hello {firstName}!";
Console.WriteLine(massage);
 */

 /* 
  Etapa 2 - Usar a interpolação de cadeia de caracteres com diversas cadeias de caracteres literais e variáveis.
 */
/*  
 string firstName = "Bob";
 string greeting = "Hello";
 string massage = $"{greeting} {firstName}!";
 Console.WriteLine(massage);
 */

/* 
 Etapa 3 - Evitar variáveis intermediárias
*/
/* 
 string firstName = "Bob";
 string greeting = "Hello";
 Console.WriteLine($"{greeting} {firstName}!");
*/


/* 
 Etapa 4 - Combinar literais textuais e interpolação de cadeia de caracteres
*/
/* 
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
 */