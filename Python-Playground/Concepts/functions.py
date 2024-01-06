def multiply(a,b):
    c=a*b
    return c

print(multiply(3,5))

def no():
    pass
print(no)

def printIndividials(*names):
    for i in names:
        print(i)
        

try: 
    100/0
except:
    print('you de craze')


# Create a class Circle

class Circle(object):
    
    # Constructor
    def __init__(self, radius):
        self.radius = radius
       
    
    # Method
    def calculate_area(self):
        area = 3.14 * self.radius
        return(area)
    
    # Method
    

printIndividials("Bala",'is',20)

me =  Circle(10)
d = me.calculate_area()
print (d)
