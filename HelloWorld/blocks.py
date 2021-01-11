name = input("Please enter your name: ")
age = int(input("How old are you, {0}? ".format(name)))

print(age)

if age < 18:
    print(f"Nah, your a scrub. Come back in {18-age} years")
elif age == 900:
    print("Sorry, Yoda, you die in Return of the Jedi")
else:
    print("You are old enough to vote")
    print("Please put an X in the box")


