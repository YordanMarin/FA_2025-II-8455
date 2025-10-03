def ejer1():
    valor = int(input("Ingrese el número de la tabla: "))
    
    i =1

    while valor <=0:
        valor = int(input("Error. Ingrese el número de la tabla: "))

    print()
    while i<=12:
        print(f"{valor} x {i} = {valor*i}")
        i+=1

def ejer2():
    sp = si = 0
    while True:
        num = int(input("Ingrese número (0 salir): "))
        if num <0:
            print("Error. No se permite negativos!")
            continue

        if num == 0:
            break

        if num% 2 ==0:
            sp+=num
        else:
            si += num #si = si+num

    print("\nSuma de pares: ",sp)
    print("Suma de impares: ",si)
    print("\nGracias por utilizar el sistema. Presione enter para salir")

def ejer3():
    f = int(input("Ingrese la cantidad de filas: "))
    c = int(input("Ingrese la cantidad de columnas: "))

    print()

    i = 0
    while i <= f:
        j = 0
        while j <= c:
            print("*", end=" ")
            j+=1
        print()
        i+=1

def ejer4():
    g = input("Genere una contraseña: ")

    print("\n------------------------------------")
    print("        VÁLIDE SU CONTRASEÑA        ")
    print("                                    ")
    print("    1. Ud. tiene 3 intentos         ")
    print("------------------------------------")

    intentos = 3

    while intentos > 0:
        c = input("\nIngrese su contraseña: ")

        if g == c:
            print("\nAcceso concebido! Bienvenido.")
            break
        else:
            intentos-=1
            print(f"Contraseña incorrecta. Tienes {intentos} intentos")
    else: print("\nCerrando programa. Ud no puede ingresar al sistema!")

ejer4()
