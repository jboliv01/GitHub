# sequential search example

shopping_list = ["milk", "pasta", "eggs", "spam", "bread", "rice"]

item_to_find = "albatross"
found_at = None # None is essentially Null

# for index in range(len(shopping_list)): # for index in range(6):
#     if shopping_list[index] == item_to_find:
#         found_at = index
#         break

if item_to_find in shopping_list: #same thing as the for loop above
    found_at = shopping_list.index(item_to_find)

if found_at is not None:
    print(f"Item found at position {found_at}")
else:
    print(f"{item_to_find} not found")

