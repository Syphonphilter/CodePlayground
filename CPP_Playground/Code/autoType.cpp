#include "fmt/format.h"
#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;

const size_t byte{8};
int autoType()
{
    std::vector<int> vi{1, 2, 3, 4, 5};
    for (std::vector<int>::iterator it = vi.begin(); it != vi.end(); ++it)
    {
        cout << format("int is {}\n", *it);
        cout << format("type of it is {}\n", typeid(it).name());
    }
}