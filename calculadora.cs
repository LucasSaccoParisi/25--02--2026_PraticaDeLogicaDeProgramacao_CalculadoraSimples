namespace Classes;

public class Numeros
{
  public int Numero1 { get; }
  public int Numero2 { get; }

  public Numeros(int numero1, int numero2)
    => (Numero1, Numero2) = (numero1, numero2);
}
