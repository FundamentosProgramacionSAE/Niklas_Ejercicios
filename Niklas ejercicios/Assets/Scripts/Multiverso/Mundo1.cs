
public class Mundo1 
{
    public int edad;
    public string nombreHermano;
    private static int millonesDinero;

    public int Dinero { get { return millonesDinero; } }

    public Mundo1()
    {
        edad = 21;
    }
    public Mundo1(int a�os)
    {
        edad = a�os;
    }
    public Mundo1(int a�os, int dinero)
    {
        edad = a�os;
        millonesDinero = dinero;
    }
}
