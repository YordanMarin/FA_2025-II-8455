class Cajero:
    saldo = 1000 #variable global

    def consultar(self) -> float:
        return self.saldo

    def depositar(self, monto) -> None:
        while True:
            try:
                monto = input("\nIngrese monto a depositar: ")
                m = float(monto)

                if(m>0):
                    self.saldo+=m
                    print("\nDeposito exitoso.")
                    break
                else: 
                    print("Error. El monto debe ser mayor a 0.\n")
                    continue

            except ValueError:
                print("Error. Solo se permiten números.\n")
                continue


