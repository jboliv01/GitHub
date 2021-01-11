# In this application, you will guess a number between 1 and 1000 and
# the computer will correctly guess your number within 10 attempts
# uses BINARY SEARCH

import random
low = 1
high = 1000

answer = random.randint(1, 1000)
attempts = 1

print(f"Please think of a number between {low} and {high}")
input("Press ENTER to start")
print()

while low != high:
    print(f"\tGuessing in the range of {low} to {high}")
    guess = low + (high - low) // 2
    print(f"This is the computer's {attempts} attempt")
    high_low = input(f"My guess is {guess}. Should I guess higher or lower? "
                     "Enter H or L, or C if my guess was correct. "
                     ).casefold()
    print()

    if high_low == "h":
        low = guess + 1

    elif high_low == "l":
        high = guess - 1

    elif high_low == "c":
        print(f"I got it in {attempts} attempts.")
        break

    else:
        print("Please enter H, L or C")

    attempts += 1
else:
    print(f"You thought of the number {low}")
    print(f"I got it in {attempts} guesses")

