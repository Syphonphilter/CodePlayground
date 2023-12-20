#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;

const int &func(int a)
{
    cout << format(" the value is {} ", a * 2);
    return a;
}
int main()

{
    const auto &x = func(43);
    cout << format(" value is {}\n ", x);
}