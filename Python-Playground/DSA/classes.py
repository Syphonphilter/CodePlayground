class Cookie:
    def __init__(self, color) -> None:
        self.color = color
    
    def getColor (self):
        return self.color
    def setColor(self, color):
        self.color = color
        return self.color
    
    

myColor = Cookie('red')
print(myColor.setColor('purple'))

## testing pointers
num1 = 11
num2 = num1


print('before')
print('num1 ', num1)
print('num2 ', num2)
print('num1 address', id(num1))
print('num2 address', id(num2))


num2 = 20
print('after')
print('num1', num1)
print('num2', num2)
print('num1 address', id(num1))
print('num2 address', id(num2))

## integers do not change when using pointers

## ditionaries change values when using pointers and shown below
d0= {'value':100}
d1 = d0

print('before')
print('dict 0  ', d1)
print('dict 1', d1)
print('dict0 address', id(d0))
print('dict1 address', id(d1))



d1['value'] = 400
print('after')
print('dict 0 ', d0)
print('dict 1', d1)
print('dict0 address', id(d0))
print('dict1 address', id(d1))

