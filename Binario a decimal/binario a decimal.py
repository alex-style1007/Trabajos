# INGRESAR NUMERO BINARIO EN DIGITOS SEPARADOS
print("Ingresar por digito:")
b0 = int(input())
b1 = int(input())
b2 = int(input())
b3 = int(input())
b4 = int(input())

# OPERACION MATEMATICA
d0 = b0 * 16
d1 = b1 * 8
d2 = b2 * 4
d3 = b3 * 2
d4 = b4 * 1

# RESULTADO FINAL
DECIMAL = d0 + d1 + d2 + d3 + d4
print("La conversion a decimal es:", DECIMAL)
