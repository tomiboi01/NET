
List<Persona> lista = new List<Persona>();

for(int i= 0; i<5; i++){
    lista.Add(new Persona(Console.ReadLine(), int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
}

Persona minEdad = new Persona("", 9999,0);


foreach(Persona i in lista){
    if (minEdad.EsMayorQue(i))
        minEdad = i;
}

Console.WriteLine(minEdad.toString());

