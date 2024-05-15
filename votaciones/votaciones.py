# Ingreso de datos
a = int(input())  # votos partido 1
b= int(input())  # votos partido 2
blancos = int(input())  # votos en blanco
anulados = int(input())  # votos anulados
n = int(input())  # total de la población
p = float(input())  # porcentaje mayor de edad

abs = int(n * p) - (a + b + blancos + anulados)
C1 = anulados < (a + b) * 0.3
C2 = (a * b) > blancos
C3 = abs < n

if (C1 or C2) and C3:
    print("LAS VOTACIONES FUERON EXITOSAS")
    if a > b:
        print("El partido 1 es el ganador")
    else:
        print("El partido 2 es el ganador")
