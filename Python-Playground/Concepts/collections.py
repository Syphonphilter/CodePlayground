cities = ['Abuja','Lagos','Jos','AkwaIbom',]
states_capital = {
    'fct':'abuja',
    'Lagos':'Ikeja',
    'Plateau':'Jos',
    'akwaIbom':'Uyo',
    
}
cloneCities =cities[:]
cloneCities[0] = 'Kaduna'
print(cities[1]);
print(cities);
print(cloneCities);

print(states_capital['fct']);
mytupule = (1,2,3,4,5,6)
print(mytupule[0:3])

my_list = [1, 2, 3, 4, 5] 
my_list.insert(2, 6) 
print(my_list)

# Define a list of numbers
numbers = [1, 2, 3, 4, 5]

# Access elements by index
print(numbers[0])  # Output: 1
print(numbers[-1])  # Output: 5 (negative index accesses from the end)

# Slicing lists
print(numbers[2:4])  # Output: [3, 4] (inclusive:exclusive)

# Adding elements
numbers.append(6)  # Appends 6 to the end of the list
print(numbers)  # Output: [1, 2, 3, 4, 5, 6]

# Extending lists
other_numbers = [7, 8, 9]
numbers.extend(other_numbers)  # Extends 'numbers' with 'other_numbers'
print(numbers)  # Output: [1, 2, 3, 4, 5, 6, 7, 8, 9]

# Removing elements
numbers.remove(3)  # Removes the first occurrence of 3
print(numbers)  # Output: [1, 2, 4, 5, 6, 7, 8, 9]

# Inserting elements
numbers.insert(2, 3)  # Inserts 3 at index 2
print(numbers)  # Output: [1, 2, 3, 4, 5, 6, 7, 8, 9]
# Creating lists with comprehensions
squared_numbers = [x ** 2 for x in numbers]
print(squared_numbers)  # Output: [1, 4, 9, 16, 25, 36, 49, 64, 81]

# Filtering elements with comprehensions
even_numbers = [x for x in numbers if x % 2 == 0]
print(even_numbers)  # Output: [2, 4, 6, 8]

odd_numbers = [x for x in numbers if x% 2 !=0]
print(odd_numbers) 

my_dup_list = [3,1,4,1,2]
my_set = set(my_dup_list)
print(my_set)
x = range(1,4)
#removed duplicates and sorts 
print(sorted(my_dup_list))
# sorts all the values
print(my_dup_list.sort())