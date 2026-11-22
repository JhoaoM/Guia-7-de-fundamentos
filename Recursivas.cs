public static class Recursivas
{
    public static int SumarPuntajes(int[] puntajes, int indice = 0)
    {
        if (indice == puntajes.Length)
            return 0;

        return puntajes[indice] + SumarPuntajes(puntajes, indice + 1);
    }
}