//ej11
Console.ReadKey();
string str;
string str2;

Console.WriteLine("Ingrese una palabra");
str = Console.ReadLine();
Console.WriteLine("Ingrese una palabra");
str2 = Console.ReadLine();

bool sonSimetricas = true;
if (str.Length != str2.Length)
    sonSimetricas = false;
else for (int i=0; i<str.Length; i++)
    {       
        if (str[i] != str2[str2.Length-1-i])
        {
            sonSimetricas = false;
            break;
        }
    }
Console.WriteLine(sonSimetricas);


