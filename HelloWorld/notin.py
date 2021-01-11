activity = input("What would you like to do today? ")

if "cinema" not in activity.casefold(): #.casefold converts to lowercase, its better to use for string comparisons than .lowercase
    print("But I want to go to the cinema")

# string comparisons are case sensitive
