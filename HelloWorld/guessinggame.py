import random

highest = 1000
lowest = 1
answer = random.randint(lowest, highest)
guess = 0
attempt = 1

print(answer) # TODO: Remove after testing


print(f"Please guess number between {lowest} and {highest}: ")

while guess != answer:
    print(f"Attempt # {int(attempt)}")
    guess = int(input())
    if guess == answer:
        print("Correct")
        break
    elif guess < answer and guess != 0:
        print("Guess higher")
        attempt += 1
    elif guess != 0:
        print("Guess lower")
        attempt += 1
    else: # if guess == 0, the user shall exit the application
        print("Congrats you have quit")
        break




#print("Please guess number between 1 and 10: ")
#guess = int(input())

# if guess < answer:
#     print("Please guess higher")
#     guess = int(input())
#     if guess == answer:
#         print("well Done, you guessed it")
#     else:
#         print("Sorry, incorrect guess")
# elif guess > answer:
#     print("Please guess lower")
#     guess = int(input())
#     if guess == answer:
#         print("Well done, you guessed it")
#     else:
#         print("Sorry, Incorrect guess")
# else:
#     print("You got it first time")



# print("Please guess number between 1 and 10: ")
# guess = int(input())
#
# if guess != answer:
#     if guess < answer:
#         print("Please guess higher")
#     else:
#         print("Please guess lower")
#     guess = int(input())
#     if guess == answer:
#         print("Well done")
#     else:
#         print("Sorry, you have not guessed correctly")
# else:
#     print("You got it first time")


# print(f"Please guess number between {lowest} and {highest}: ")
# guess = int(input())
#
# if guess == answer:
#     print("You got it first time")
# else:
#     if guess < answer:
#         print("Please guess higher")
#     else:
#         print("Please guess lower")
#     guess = int(input())
#     if guess == answer:
#         print("Well done")
#     else:
#         print("Sorry, you have not guessed correctly")
#
