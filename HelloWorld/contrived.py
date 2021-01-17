numbers = [1, 45, 31, 16, 60]

# using else in a for loop

for number in numbers:
    if number % 8 == 0:  # if number is divisible by 8
        # reject the list
        print("The numbers are unacceptable")
        break
else:
    print("Ok")
