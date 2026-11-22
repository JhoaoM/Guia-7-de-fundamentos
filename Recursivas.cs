public static class Recursivas
{
    public static int SumarPuntajes(int[] puntajes, int indice = 0)
    {
        if (indice == puntajes.Length)
            return 0;

        return puntajes[indice] + SumarPuntajes(puntajes, indice + 1);
    }

    public static int BuscarCodigo(string[] codigos, string codigo, int indice = 0)
    {
        if (indice == codigos.Length)
            return -1;

        if (codigos[indice] == codigo)
            return indice;

        return BuscarCodigo(codigos, codigo, indice + 1);
    }

    public static int ContarArchivosConPalabra(string[] archivos, string palabra, int indice = 0)
    {
        if (indice == archivos.Length)
            return 0;

        int coincide = archivos[indice].Contains(palabra) ? 1 : 0;

        return coincide + ContarArchivosConPalabra(archivos, palabra, indice + 1);
    }

    public static int Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }
}