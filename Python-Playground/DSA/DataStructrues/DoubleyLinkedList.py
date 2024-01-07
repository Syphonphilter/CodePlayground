from DListNode import DListNode as dnode
class DoubleyLinkedList:
    def __init__(self,value) -> None:
    
        self.head = dnode(value)
        self.tail = self.head
        self.length  = 1;
    def printList(self):
        temp = self.head
        listValues = []
        while temp:
            listValues.append(temp.value)
            temp = temp.next
        return listValues
    def push(self,value):
        newNode = dnode(value)
        if self.length ==0:
            self.head = newNode
            self.tail = newNode
            return self
        self.tail.next = newNode
        newNode.prev = self.tail
        self.tail = newNode
        self.length +=1
        return self
    
    def pop(self):
        temp = self.tail
        if(self.length ==0):
            return None
        if (temp.prev ==None):
            return None
        if(self.length==1):
            self.head = None
            self.tail = None
        self.tail = self.tail.prev
        self.tail.next = None
        temp.prev = None
        self.length-=1
        return self
    def unshift (self, value):
        newNode= dnode(value)
        if self.length==0:
            self.head = newNode
            self.tail = newNode
        newNode.next = self.head
        self.head.prev = newNode
        newNode.prev = None
        self.head =newNode
        self.length +=1
        return self
    def shift(self):
        temp = self.head
        if(self.length ==0):
            return  None
        self.head = self.head.next
        temp.next = None
        self.head.prev = None
        self.length -=1;
        return True
    
    def get(self, index):
        if(index >= self.length or index <0 ):
            return None
        if(self.length ==0):
            return None
        temp = self.head 
        if(self.length/2 > index):
            for _ in range(index):
                temp= temp.next
        else:
            for _ in range(self.length -1, index, -1):
                temp = temp.prev
        return temp
    def setter(self, index, value):
        temp = self.get(index)
        if(temp):
            temp .value = value
            return True
        return False
    
    def insert(self ,index,value):
        newNode = dnode (value)
        if(index >= self.length or index <0 ):
            return False
        if(index ==0): return self.unshift(value)
        if(index ==self.length): return self.push(value)

        before= self.get(index-1)
        after = before.next
        newNode.next = after
        newNode.prev = before
        before.next = newNode
        after.prev = newNode
        self.length+=1
        return True;
    def remove(self, index):
        if(index >= self.length or index <0 ):
            return False
        if(index ==0): return self.shift()
        if(index ==self.length-1): return self.pop()
        current= self.get(index)
        after = current.next
        before = current.prev
        before.next = current.next 
        after.prev = current.prev
        current.next = None
        current.prev = None
        
        self.length-=1
        return True
        
        
        
        
            
        
dlist = DoubleyLinkedList(20)
dlist.push(21)
dlist.push(189)
dlist.push(113)
dlist.push(8798)
print(dlist.printList())
dlist.pop()
dlist.unshift(4)
print(dlist.printList())
dlist.shift()
print(dlist.printList())
print(dlist.setter(0,1997))
dlist.insert(1,109898)
print(dlist.printList())
dlist.remove(1)
print(dlist.printList())