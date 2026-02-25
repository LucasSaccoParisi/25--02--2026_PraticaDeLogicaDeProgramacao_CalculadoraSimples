using Classes;

var conta = new Numeros(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

int resul;

string Simbolo = Console.ReadLine();

switch (Simbolo){
  case "+":
    resul = conta.Numero1 + conta.Numero2;
    Console.WriteLine(resul);
    break;
  case "-":
    resul = conta.Numero1 - conta.Numero2;
    Console.WriteLine(resul);
    break;
  case "*":
    resul = conta.Numero1 * conta.Numero2;
    Console.WriteLine(resul);
    break;
  case "/":
    resul = conta.Numero1 / conta.Numero2;
    Console.WriteLine(resul);
    break;
  default:
    Console.WriteLine("Que?");
    break;
}
