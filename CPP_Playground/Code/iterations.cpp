#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;
int main()
{
    int array[]{1, 2, 3, 4, 5, 5};
    for (const auto &e : array)
    {
        print("element is {}\n", e);
    }
}