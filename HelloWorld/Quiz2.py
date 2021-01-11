for x in range(30):
    if x % 3 == 0 or x % 5 == 0:
        continue
    print(f'{x} % 3 = {x % 3}')
    print(f'{x} % 5 = {x % 5}')
    print(x)
    print()
