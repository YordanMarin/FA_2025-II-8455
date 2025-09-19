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

ejer1()

