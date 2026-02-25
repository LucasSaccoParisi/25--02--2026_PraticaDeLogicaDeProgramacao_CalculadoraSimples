#include <iostream>
using namespace std;

int main(){
  int x;
  int y;
  char simbolo;

  cin >> x >> y >> simbolo;

  switch(simbolo){
    case '+':
      std::cout << x + y;
      break;
    case '-':
      std::cout << x - y;
      break;
    case '*':
      std::cout << x * y;
      break;
    case '/':
      std::cout << x / y;
      break;
    default:
      cout << "Que?";
  }

  return 0;
}
