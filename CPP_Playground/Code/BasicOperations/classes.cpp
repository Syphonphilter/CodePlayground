#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;

class C1
{
    int c1a{};

public:
    void setValue(int value);
    int getValue();
};
void C1::setValue(int value) {
    c1a = value;
}
int C1::getValue() {
    return c1a;
}
int main()

{

    const auto &x = func(43);
    cout << format(" value is {}\n ", x);
}