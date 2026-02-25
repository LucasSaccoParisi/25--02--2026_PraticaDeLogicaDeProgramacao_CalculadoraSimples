namespace Classes;

public class Carro
{
  public string Marca { get; }
  public string Modelo { get; }
  public string Cor { get; }

  public Carro(string marca, string modelo, string cor)
    => (Marca, Modelo, Cor) = (marca, modelo, cor);
}
