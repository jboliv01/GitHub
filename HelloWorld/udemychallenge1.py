options = ["Exit", "Learn Python", "Go mountainbiking", "Play Skyrim",\
          "Cook dinner", "Climb Mount Everest"]


selection = None

while selection != 0:

    for i in range(len(options)):
        print(f"{i}. {options[i]}")

    selection = int(input("\nPlease enter your selection "))
    while selection < len(options):
        print(f"You've selected {options[selection]}\n---------------------------")
        break
    else:
        print("Invalid entry \n")

else:
    print("You have Exited the program")

#test