shopping_list = ["milk", "pasta", "eggs", "spam", "bread", "rice"]


for item in shopping_list:
    if item == "spam":
            continue # causes all the code in the remaining block to be skipped

    print("Buy " + item)

print('--------------------')

for item in shopping_list:
    if item == "spam":
        break # breaks the for loop

    print("Buy " + item)