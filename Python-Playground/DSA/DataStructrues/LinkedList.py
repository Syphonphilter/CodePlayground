
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
            return self
                
            
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
print(myList.printList())
myList.pop()
print(myList.printList())
