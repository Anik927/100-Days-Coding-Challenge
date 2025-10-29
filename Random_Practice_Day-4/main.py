import time
timestamp = time.strftime('%H: %M: %S')
print("The Time is",timestamp)
hour = int(time.strftime('%H'))
minute = time.strftime('%M')
second = time.strftime('%S')

if(hour>4 and hour<12):
    print("Good Morning")    
elif(hour>=12 and hour<18):
    print("Good After Noon")
elif(hour>=18 and hour<20):
    print("Good Evening")
else:
    print("Good Night")


hour = int(input("Enter Hour in 24 Hour System:"))
minute = int(input("Enter Minute:"))
second = int(input("Enter Second:"))

if(hour>4 and hour<12):
    print("Good Morning")    
elif(hour>=12 and hour<18):
    print("Good After Noon")
elif(hour>=18 and hour<20):
    print("Good Evening")
else:
    print("Good Night")
