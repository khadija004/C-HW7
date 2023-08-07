using C_HW7;

//Console.WriteLine("Enter your sentence");
//string input = Console.ReadLine();


//Console.WriteLine("Enter your search");
//string search = Console.ReadLine();


//Console.WriteLine(input.CustomContains(search));

Console.WriteLine("Enter your sentence");
string sentence=Console.ReadLine();

Console.WriteLine("Enter your split character");
char input=char.Parse(Console.ReadLine());


sentence.CustomSplit(input);
