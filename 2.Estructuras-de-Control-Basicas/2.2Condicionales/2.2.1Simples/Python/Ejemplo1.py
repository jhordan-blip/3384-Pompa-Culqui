# Entrada
a = int(input("Ingrese el valor de a: "))
b = int(input("Ingrese el valor de b: "))

# Proceso
if a > b:
    # Intercambiar los valores
    temp = a
    a = b
    b = temp

# Salida
print("Valor de a:", a)
print("Valor de b:", b)
