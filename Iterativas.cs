public static class Iterativas
{
    public static int SumarPuntajes(int[] puntajes)
    {
        int suma = 0;
        for (int i = 0; i < puntajes.Length; i++)
        {
            suma += puntajes[i];
        }
        return suma;
    }

    public static int BuscarCodigo(string[] codigos, string codigo)
    {
        for (int i = 0; i < codigos.Length; i++)
        {
            if (codigos[i] == codigo) return i;
        }
        return -1;
    }

    public static int ContarArchivosConPalabra(string[] archivos, string palabra)
    {
        int cantidad = 0;
        for (int i = 0; i < archivos.Length; i++)
        {
            if (archivos[i].Contains(palabra))
            {
                cantidad++;
            }
        }
        return cantidad;
    }
}