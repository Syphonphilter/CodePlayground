#include "fmt/format.h"
#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;

const size_t byte{8};
int FloatingPointType()
{
    float f{5e2};
    double df{};
    long double ldf{};
    cout << format("size of float f is {} bits\n", sizeof(f) * byte);
    cout << format("size of double df is {} bits\n", sizeof(df) * byte);
    cout << format("size of double ldf is {} bits\n", sizeof(ldf) * byte);

    cout << format("value of f is {}\n", f);
}