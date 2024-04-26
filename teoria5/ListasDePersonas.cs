class ListaDePersonas
{
    private List<Persona> listaDePersonas { get; set; } = new List<Persona>();
public void Agregar(Persona p)
{
    listaDePersonas.Add(p);
}

public Persona? this[int dni]{

    get
    {
        return listaDePersonas.Find(x => (int)x[2] == dni);

    }
}

public List<Persona> this[char c]{

    get{
        List<Persona> lista = new List<Persona>();
        foreach(Persona p in listaDePersonas)
        if (((string)p[0])[0] == c)
            lista.Add(p);
        return lista;
    }
}

}