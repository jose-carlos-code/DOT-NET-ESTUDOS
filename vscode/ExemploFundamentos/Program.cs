using ExemploFundamentos.Common.Models;

int a = 1;
string b = "2";

// casting / cast

// é possível converter null com o Convert
int c = Convert.ToInt32(null);

int d = int.Parse("5");

string e = a.ToString();

Console.WriteLine($"c: {a + c}");

Console.WriteLine("STRING QUE VIROU NÚMERO: " + d);

Console.WriteLine("NÚMERO QUE VIROU STRING: " + e);

Pessoa pessoa = new Pessoa();
pessoa.Apresentar("José carlos");