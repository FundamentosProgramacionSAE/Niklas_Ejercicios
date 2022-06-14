
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
    public Mundo1(int años)
    {
        edad = años;
    }
    public Mundo1(int años, int dinero)
    {
        edad = años;
        millonesDinero = dinero;
    }
}
