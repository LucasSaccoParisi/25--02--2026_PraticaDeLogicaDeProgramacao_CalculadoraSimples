import java.util.Scanner;

public class calculadora {
  
  public static void main(String[] args)
  {
    System.out.println("Coloque os seus números (somente 2 números) e o operador desejado:");
    Scanner numeroUm = new Scanner(System.in);
    Scanner numeroDois = new Scanner(System.in);
    Scanner simbolo = new Scanner(System.in);

    int x = numeroUm.nextInt();
    int y = numeroDois.nextInt();
    String calc = simbolo.nextLine();

    switch (calc) {
      case "+":
        System.out.println(x + y);
        break;
      case "-":
        System.out.println(x - y);
        break;
      case "*":
        System.out.println(x * y);
        break;
      case "/":
        System.out.println(x / y);
        break;
      default:
        System.out.println("Que?");
        break;
    }
  }
}
