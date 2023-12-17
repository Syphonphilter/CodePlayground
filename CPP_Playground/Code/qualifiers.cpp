// types of qualifiers
// CV , cont mutable, volatile
// Storage Duration, static, register, exern
#include "fmt/format.h"
#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;

int func()
{
    // static variable tells the system to no longer re initialize the variable everytime it is called
    static int x{7};
    return ++x;
}
int qualifiers()
{
    // const qualified
    const int i{42};
    cout << format("func returns {}\n", func());
    cout << format("func returns {}\n", func());
    cout << format("func returns {}\n", func());
}