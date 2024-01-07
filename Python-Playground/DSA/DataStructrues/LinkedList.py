
from ListNode import ListNode as node
class LinkedList:
    def __init__(self, value):
        self.head = node(value)
        self.tail = self.head
        self.length  = 1;
      
    def push(self,value):
        newNode = node(value)
        print (self.length)
        if(self.length ==0):
            self.head= newNode
            self.tail = newNode
        else:
            self.tail.next = newNode
            self.tail = newNode
        self.length +=1
        return self
    def pop(self):
        if(self.length ==0 ):
            return None
        else:
            temp = self.head
            pre = self.head
            while temp.next:
                pre = temp
                temp = temp.next
            self.tail = pre
            self.tail.next = None
        self.length -=1
        if(self.length ==0):
            self.head = None
            self.tail = None
        return self
        
    def unshift(self, value):
        newNode = node(value)
        if (self.length == 0):
            self.head  = newNode
            self.tail = newNode
        else:
            newNode.next = self.head
            self.head = newNode;
        self.length+=1  
        return self

    def shift(self):
        if(self.length ==0 ):
            return None
        else: 
            temp = self.head
            self.head= self.head.next
            temp.next = None
        self.length -=1
        if (self.length ==0):
            self.tail = None
       
        return temp
    def get(self,index)-> node:
        if(self.length ==0 ):
            return None
        elif (index> self.length -1 or index <0 ):
            return None
        else:
            temp: node | None = self.head
            for i in range(index):
                temp = temp.next
            return temp
                
    def setter(self,index,value)-> bool:
        if(self.length ==0 ):
            return False
        elif (index> self.length or index <0 ):
            return False
        else:
            i = 0
            temp = self.head
            for i in range(index):
                temp = temp.next
            temp.value = value
            return True
        
    def insert(self,index,value)-> bool:
        newNode = node(value)
        if(index==0):
           return self.unshift(value)
        elif(index == self.length):
           return self.push(value)
        elif(self.length ==0):
            return False
        elif (index> self.length -1 or index <0 ):
            return False
        else:
            i = 0
            temp = self.get(index-1)
            newNode = temp.next
            temp.next = newNode
            self.length +=1
            return True
        
    def remove(self, index):
        if(index==0):
           return self.shift()
        elif(index == self.length -1):
           return self.pop()
        elif(self.length ==0):
            return None
        elif (index> self.length -1 or index <0 ):
            return  None
        else:
            prev: node = self.get(index -1)
            temp = prev.next
            prev.next  = temp.next
            temp.next = None
            
                            
            self.length -=1
            return temp
        
    def reverse(self):
        temp = self.head
        self.head = self.tail
        self.tail = temp
        pre = None
        reverseNext = temp.next
        counter = 0
        while(counter<self.length):
            reverseNext = temp.next
            temp.next = pre
            pre = temp
            temp = reverseNext
            counter+=1
        return self.head
            
        
                
            
                
            
    def printList(self):
        temp =self.head
        list_values = []
        while temp:
            list_values.append(temp.value)
            temp = temp.next
            
        return list_values

myList = LinkedList(1)
myList.push(3);
myList.push(10);
myList.push(4);
# print(myList.printList())
# myList.pop()
myList.unshift(19)
# print(myList.printList())
# myList.shift()
print(myList.printList())
print(myList.get(0).value)
print(myList.setter(0,1997))
print(myList.printList())
print(myList.get(4).value)

