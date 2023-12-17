#include "fmt/format.h"
#include <fmt/core.h>
#include <iostream>
#include <cstdint>

using namespace fmt;
using std::cout;

using points_t = uint32_t;
using rank_t = uint64_t;

struct score
{
    points_t p{};
    rank_t r{};
};
int typeAliases()
{
    score s{30, 1};
    cout << format("user scored {} with a rank of {}\n", s.p, s.r);
}