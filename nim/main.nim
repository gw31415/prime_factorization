import math

var
    arr: seq[int]
    temp: int

for n in 1..100000:
    arr = @[]
    temp = n
    for i in 2..int(sqrt(n.float) + 1):
        while temp mod i == 0:
            arr.add(i)
            temp = temp div i
    if temp != 1:
        arr.add(temp)
    if len(arr) == 0:
        arr.add(n)
