edad = int(input("Introduce tu edad: "))

if 0 <= edad <= 12:
    print("Niño")
elif 13 <= edad <= 19:
    print("Adolescente")
elif 20 <= edad <= 59:
    print("Adulto")
elif edad >= 60:
    print("Adulto mayor")
else:
    print("Edad no válida")
