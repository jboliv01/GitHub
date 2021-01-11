#         012345678901234
parrot = "Norwegian Blue"

print(parrot)
print(parrot[3]) # prints the 4th letter in the index
print(parrot[4])
print(parrot[9])
print(parrot[3])
print(parrot[6])
print(parrot[8])

print()
print(parrot[-1])
print(parrot[-2])
print(parrot[-14])

StringLength = len((parrot))-1
print(StringLength)

print(parrot[10:])
print(parrot[:6] + parrot[6:])

print(parrot[-4:-2])

print(parrot[0:6:2]) #step through in 2s
print(parrot[0:6:3]) #step through in 3s

number = "9,233;372:036 854;775,807"
seperators = (number[1::4])
print(seperators)

values = "".join(char if char not in seperators else " " for char in number).split()
print([int(val) for val in values])