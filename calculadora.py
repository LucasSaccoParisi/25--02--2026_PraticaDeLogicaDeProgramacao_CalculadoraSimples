x = int(input("Coloque o seu primeiro numero: "))
y = int(input("Coloque o seu segundo numero: "))
calculo = input("Coloque o operador: ")

if calculo == "+":
    print(x + y)
elif calculo == "-":
    print(x - y)
elif calculo == "*":
    print(x * y)
elif calculo == "/":
    print(x / y)
else:
    pass
