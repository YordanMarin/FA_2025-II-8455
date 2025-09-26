def ejer1():
    edad = int(input("Ingrese edad: "))

    if edad < 18:
        print("No puede votar.")
    elif edad < 25:
        print("Puede votar.")
        print("No puede ser candidato a un cargo politico")
    else:
        print("Puede votar.")
        print("Puede ser candidato a un cargo politico")

def ejer2():
    lado1 = int(input("Ingrese lado 1: "))
    lado2 = int(input("Ingrese lado 2: "))
    lado3 = int(input("Ingrese lado 3: "))

    if lado1==lado2==lado3:
        print("EQUILATERO")
    elif lado1 == lado2 or lado2==lado3:
        print("ISOsCELES")
    else:
        print("ESCALENO")

def ejer3():
    n = int(input("Ingrese el valor de n: "))
    suma =0
    print()
    for i in range(1,n+1):
        print(i)

        if(i % 2 == 0):
            suma += i
    print("\nSuma de pares: ",suma)

def ejer4():
    cant = int(input("Ingrese la cantidad de números:"))
    p = im = c = 0
    print()
    for i in range(1,cant+1):
        num = int(input(f"Ingrese número {i}: "))

        if num == 0:
            c+=1
        elif num %2 ==0:
            p+=1
        else: 
            im+=1

    print("\nCantidad de pares: ",p)
    print("Cantidad de impares: ",im)
    print("cantidad de ceros: ", c)


ejer4()

