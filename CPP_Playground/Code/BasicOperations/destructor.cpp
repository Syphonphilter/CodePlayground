#include <iostream>

class MyClass
{
public:
    // Constructor
    MyClass()
    {
        std::cout << "Constructor called" << std::endl;
    }

    // Destructor
    ~MyClass()
    {
        std::cout << "Destructor called" << std::endl;
    }
};

int main()
{
    {
        MyClass obj; // Object created
    }                // Object goes out of scope here and destructor is automatically called

    // Object explicitly created and deleted
    MyClass *objPtr = new MyClass();
    delete objPtr; // Destructor is explicitly called here

    return 0;
}
