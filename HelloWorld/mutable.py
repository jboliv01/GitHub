# an immutable object can't be changed while a mutable object can be changed
# notice how the list ID does not change after adding an item to the list
# an immutable object such as a string would destroy the space in memory and create
# a new space

shopping_list = ["milk",
                 "pasta",
                 "eggs",
                 "spam",
                 "bread",
                 "rice"]

another_list = shopping_list
print(id(shopping_list))
print(id(another_list))

shopping_list += ["cookies"]
print(shopping_list)
print(id(shopping_list))
print(id(another_list))
print()

a = b = c = d = e = f = another_list #chain assignment
print(a)
print("Adding cream")
a.append("cream")
print(c)
print(d)
print(id(a))