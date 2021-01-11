quote = """
Alright, but apart from the Sanitation, the Medicine, Education, Wine,
Public Order, Irrigation, Roads, the Fresh-Water System,
and Public Health, what have the Romans ever done for us?
"""
quote2 = ""

# Use a for loop and an if statement to print just the capitals in the quote above.
for capital in quote:
    if capital.isupper():
        quote2 = quote2 + capital

print(quote2)