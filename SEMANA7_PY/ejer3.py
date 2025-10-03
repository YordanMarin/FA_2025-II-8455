while True:
    num = int(input("Ingrese número: "))
    suma = 0

    for i in range(1, num+1):
        suma += i
        print(i, end=" ")
    print("\n\nSuma: ",suma)

    opc = input("\n¿Desea continar? (presione N para salir): ")

    if opc == "N": break