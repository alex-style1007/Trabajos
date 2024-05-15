print("SALARIO MENSUAL:")
SMV = float(input())

print("Tipo De Contrato:")
print("INGRESE 1 SI ES DEPENDIENTE Y 2 SI ES INDEPENDIENTE")
TC = float(input())

if TC == 2:
    print("Ingrese su tipo de riesgo")
    TR = float(input())

    if TR == 1:
        ARL = ((SMV * 0.4) * (0.00522))
        Pension = ((SMV * 0.04) * (0.16))
        Salud = ((SMV * 0.04) * (0.125))
        SR = SMV - (Salud + Pension + ARL)
        SA = SR * 12
        print("Salario Real:", SR)
        print("Salario Anual:", SA)
    elif TR == 2:
        ARL = ((SMV * 0.4) * (0.01044))
        Pension = ((SMV * 0.04) * (0.16))
        Salud = ((SMV * 0.04) * (0.125))
        SR = SMV - (Salud + Pension + ARL)
        SA = SR * 12
        print("Salario Real:", SR)
        print("Salario Anual:", SA)
    elif TR == 3:
        ARL = ((SMV * 0.4) * (0.02436))
        Pension = ((SMV * 0.04) * (0.16))
        Salud = ((SMV * 0.04) * (0.125))
        SR = SMV - (Salud + Pension + ARL)
        SA = SR * 12
        print("Salario Real:", SR)
        print("Salario Anual:", SA)
    elif TR == 4:
        ARL = ((SMV * 0.4) * (0.04350))
        Pension = ((SMV * 0.04) * (0.16))
        Salud = ((SMV * 0.04) * (0.125))
        SR = SMV - (Salud + Pension + ARL)
        SA = SR * 12
        print("Salario Real:", SR)
        print("Salario Anual:", SA)
    elif TR == 5:
        ARL = ((SMV * 0.4) * (0.06960))
        Pension = ((SMV * 0.04) * (0.16))
        Salud = ((SMV * 0.04) * (0.125))
        SR = SMV - (Salud + Pension + ARL)
        SA = SR * 12
        print("Salario Real:", SR)
        print("Salario Anual:", SA)
else:
    ARL = 0
    Pension = ((SMV * 0.04) * (0.04))
    Salud = ((SMV * 0.04) * (0.04))
    SR = SMV - (Salud + Pension + ARL)
    SA = SR * 12
    print("Salario Real:", SR)
    print("Salario Anual:", SA)
