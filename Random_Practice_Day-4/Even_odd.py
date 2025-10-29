num = int(input("Enter Num: "))
check = int(input("Emter the number to divide by: "))

if (num%2==0):
    print("The number is even")
    if(num%check==0):
        print("The number is divisible by",check)
    else:
        print("The number isn't divisible by",check)
else:
    print("The number is odd")