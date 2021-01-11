number = input("Please enter a series of numbers, using any separators you like: ")
# number = "9,233;372:036 854;775,807"
separators = ""
count = 0
for x in number:
    if not x.isnumeric():
        separators = separators + x
        count = count + 1

print(separators)
print(count)

values = "".join(char if char not in separators else " " for char in number).split()
print([int(val) for val in values])
print(sum([int(val) for val in values]))