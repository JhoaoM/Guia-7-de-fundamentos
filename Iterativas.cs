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
}