name = input("What's your name? ")
age = int(input("What's your age? "))

max_age = 30
min_age = 18

if max_age >= age >= min_age:
    print(f"Hello {name}, welcome to the Holiday!")
elif age <= min_age:
    print(f"Sorry {name}, you must be {min_age} or older")
else:
    print(f"Sorry {name}, you must be younger than {max_age}")



