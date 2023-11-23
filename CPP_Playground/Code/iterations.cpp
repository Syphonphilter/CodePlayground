#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;
int iterations()
{

    int array[]{0, 2, 3, 4, 5, 5};
    const char string[]{"string"};
    // printing with and without null terminator
    for (const auto &e : string)
    {

        // remove this if you dont want null temrinator
        if (e)
            print("element is {}\n", e);
    }
    // for loop with range
    for (const auto &e : string)
    {
        if (e == 0)
            break;
        print("element is {}\n", e, string);
    }
    // for loop with pointers and testing for null terminators
    for (auto *p = string; *p; ++p)
    {
        print("element is {}\n", *p);
    }
}