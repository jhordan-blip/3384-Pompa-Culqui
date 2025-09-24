# Solicitar valores al usuario
numero1 = int(input("Ingrese el 1er valor: "))
numero2 = int(input("Ingrese el 2do valor: "))

# Condicionales
if numero1 > numero2:
    temp = numero1
    numero1 = numero2
    numero2 = temp
elif numero1 < numero2:
    numero1 = numero1 + 1
    numero2 = numero2 + 1

# Mostrar resultados
print("Valor de a:", numero1)
print("Valor de b:", numero2)
