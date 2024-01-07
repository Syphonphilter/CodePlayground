import numpy as np


# Create a NumPy array called 'a' with the values [0, 1, 7, 3, 7]
a = np.array([0, 1, 7, 3, 7])
a.shape
a.size
a.ndim

# Print the value at index 0 of the array
print(a[0])

a = np.array([1,2,3,4,5])
print(a[0])

a.size

a.shape

a.ndim

u = np.array([1,3])
v = np.array([3,4])
z = u+v
print (z)


# dot product 
dot = np.dot(u,v)

# broadcasting
broadcast = u+1

print(broadcast)
 