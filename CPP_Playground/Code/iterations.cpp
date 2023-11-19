#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;
int main()
{

    int array[]{0, 2, 3, 4, 5, 5};
    const char string[]{"string"};
    // for loop wiht range
    for (const auto &e : string)
    {
        if (e == 0)
            break;
        print("element is {}\n", e, string);
    }
    // for loop with pointers
    for (auto *p = string; *p; ++p)
    {
        print("element is {}\n", *p);
    }
}