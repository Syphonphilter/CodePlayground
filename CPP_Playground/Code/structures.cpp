#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;
struct SS
{
    int i{};
    double d{};
    const char *s{};
};
int main()
{
    SS s1{1, 4.3, "string one"};
    auto *sp = &s1;
    sp->d = 30.1;

    print("elements are {} {} {} \n", sp->i, sp->d, sp->s);
}