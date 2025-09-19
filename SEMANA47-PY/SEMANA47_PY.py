def ejer1():
    edad = int(input("Ingrese una edad: "))

    if edad < 18:
        print("Menor de edad.")
    elif edad <=64:
        print("Adulto")
    else: 
        print("Adulto mayor")

def ejer2():
    an = int(input("Ingrese el año: "))

    print()
    if (an % 4 == 0 and an % 100 != 0) or an % 400 ==0 :
        print("Es un año bisiesto")
    else:
        print("No es un año bisiesto")

    if an % 2 ==0:
        print("El año es par")
    else:
        print("El año es impar")

def ejer3():
    monto = float(input("Ingrese monto en soles: "))

    print("\n1. Dolares")
    print("2. Euros\n")

    opcion = int(input("Ingrese una opción: "))

    match opcion:
        case 1: print("Dolares: ", round((monto/3.75),2))
        case 2: print("Euros: ", round((monto/4.05),0))
        case _:print("Opción invalida")

import math

def ejer4():

    print("Bienvenido al sistema de calculos de áreas\n")
    print("1. Cuadrado")
    print("2. Rectangulo")
    print("3. Triangulo")
    print("4. Circulo\n")

    opcion = int(input("Ingrese una opción: "))

    match opcion:
        case 1: 
            lado = int(input("Ingrese lado: "))
            print("Área del cuadrado: ", lado*lado)
        case 2:
            bse = int(input("Ingrese la base: "))
            alt = int(input("Ingrese la altura: "))
            print("Área del rectangulo: ", bse*alt)
        case 3:
            bse2 = int(input("Ingrese la base: "))
            alt2 = int(input("Ingrese la altura: "))
            print("Área del triangulo: ", (bse*alt)/2)
        case 4:
            radio = float(input("Ingrese la radio: "))
            print("Área del circulo: ", round((math.pi * radio**2),2))
        case _: print("Opción invalida")

ejer4()
