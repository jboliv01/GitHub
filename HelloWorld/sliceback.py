          #01234567890123456789012345
letters = "abcdefghijklmnopqrstuvwxyz"

backwards = letters[25::-1]
backwards2 = letters[::-1]
print(backwards)
print(backwards2)

backwards3 = letters[16:13:-1]
print(backwards3) #result: qpo

backwards4 = letters[4::-1]
print(backwards4) #result edcba

backwards5 = letters[25:17:-1]
print(backwards5) #result: last 8 chars of the string in reverse order

print(letters[-1:])
print(letters[:1])
print(letters[0])

