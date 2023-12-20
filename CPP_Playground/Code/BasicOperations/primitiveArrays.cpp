#include "fmt/format.h"
#include <fmt/core.h>
#include <iostream>
#include <cstdint>

using namespace fmt;
using std::cout;

using points_t = uint32_t;
using rank_t = uint64_t;

int primitiveArrays()
{
    // initialize array
    int ia[5]{};
    // inittalize a pointer to the mem location of the array
    int *ip = ia;
    // initalize first element to 2
    *ip = 1;
    // increment array
    ++ip;
    *ip = 2;
    // shortcut
    *(++ip) = 3;
    // range for loop used to trvaerse an array
    for (const auto &nums : ia)
    {
        cout << format("{}", nums[ia]);
    }
}