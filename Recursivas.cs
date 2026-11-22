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
}