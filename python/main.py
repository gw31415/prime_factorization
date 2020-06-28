for n in range(1,100000):
    arr = []
    temp = n
    for i in range(2, int(-(-n**0.5//1))+1):
        while temp%i==0:
            arr.append(i)
            temp //= i
    if temp!=1:
        arr.append(temp)
    if arr==[]:
        arr.append(n)
