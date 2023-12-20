#include <fmt/core.h>
#include <iostream>

using namespace fmt;
using std::cout;

int PrimeNumbers()
{
    bool prime_flag{false};
    for (auto number = 2; number < 100; ++number)
    {

        prime_flag = true;
        for (int p_factor = 2; p_factor < number; ++p_factor)
        {
            if (number % p_factor == 0)
            {
                prime_flag = false;
                break;
            }
        }
        if (prime_flag)
            cout << format("number is prime {}", number);
    }
}
