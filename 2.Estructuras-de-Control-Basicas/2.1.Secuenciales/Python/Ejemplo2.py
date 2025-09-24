import math

# Inicio
radio = float(input("Ingrese el radio del cilindro: "))
altura = float(input("Ingrese la altura del cilindro: "))

# Proceso
volumen = math.pi * (radio ** 2) * altura

# Salida
print(f"El volumen del cilindro es de: {volumen}")