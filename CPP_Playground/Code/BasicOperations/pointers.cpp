#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;
int pointers()
{
    int x{7};
    int *ip = &x;
    int &y = x;

    cout << format("The value of x is {}\n", x);
    cout << format("The value of y is {}\n", y);
    cout << format("The value of *ip is {}\n", *ip);
    y = 58;
    cout << format("The value of x is {}\n", x);
    cout << format("The value of y is {}\n", y);
    cout << format("The value of *ip is {}\n", *ip);
}