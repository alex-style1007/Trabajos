import math

print("Ingrese los coeficientes de la ecuación cuadrática (ax^2 + bx + c = 0):")

a = float(input("Coeficiente a: "))
b = float(input("Coeficiente b: "))
c = float(input("Coeficiente c: "))

# Calculamos el discriminante
discriminante = b * b - 4 * a * c

if discriminante > 0:
    # Dos soluciones reales distintas
    x1 = (-b + math.sqrt(discriminante)) / (2 * a)
    x2 = (-b - math.sqrt(discriminante)) / (2 * a)
    print(f"Las soluciones reales son: x1 = {x1}, x2 = {x2}")
elif discriminante == 0:
    # Una solución real doble
    x = -b / (2 * a)
    print(f"La solución real doble es: x = {x}")
else:
    # Soluciones complejas
    realPart = -b / (2 * a)
    imaginaryPart = math.sqrt(-discriminante) / (2 * a)
    print(f"Las soluciones son complejas: {realPart} + {imaginaryPart}i y {realPart} - {imaginaryPart}i")
