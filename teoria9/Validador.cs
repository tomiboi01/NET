class Validador<T>
{
    private List<ReglaValidacion<T>> listaReglas = [];
    public Validador<T> AgregarRegla(ReglaValidacion<T> reg) {listaReglas.Add(reg); return this;}

    public bool Validar(T objeto, out List<string> errores){
        errores = [];
        foreach (ReglaValidacion<T> reg in listaReglas)
            if (!reg.Ok(objeto))
                errores.Add(reg.MensajeError);
        return errores.Count == 0;
    }


}