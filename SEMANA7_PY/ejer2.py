import random
secreto = random.randint(1,20)
intentos = 3

print("*****************************************************")
print("*          BIENVENIDOS AL JUEGO ADIVINADOR          *")
print("*                                                   *")
print("*  1. Ud. debe de adivinar el número entre 1 y 20   *")
print("*  2. Ud. tiene 3 intentos                          *")
print("*  3. Se le proporcionara una pista por cada falla  *")
print("*****************************************************")

while intentos >0:
    num = int(input("\nIngrese número: "))

    if num == secreto:
        print("\nAdivinaste el número!")
        break
    else:
        intentos-=1
        if num < secreto:
            print(f"Pista: El número es mayor. Ud. tiene {intentos} intentos ")
        else:
            print(f"Pista: El número es menor. Ud. tiene {intentos} intentos ")
else: print("\nNo lograste adivinar el número ",secreto)