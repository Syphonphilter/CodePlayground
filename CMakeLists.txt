cmake_minimum_required(VERSION 3.10)
project(CPP_Executable)

# Specify the C++ standard
set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED True)

# Include directories for your project's header files
include_directories(${CMAKE_CURRENT_SOURCE_DIR}/CPP_Playground/Code)

# Add the fmt library
add_subdirectory(CPP_Playground/Utils/fmt-10.1.0)

# Specify the source files for your executable
add_executable(CPP_Executable 
CPP_Playground/Code/BasicOperations/main.cpp
CPP_Playground/Code/BasicOperations/pointers.cpp
CPP_Playground/Code/BasicOperations/iterations.cpp
CPP_Playground/Code/BasicOperations/structures.cpp
CPP_Playground/Code/BasicOperations/floatingPointTypes.cpp
CPP_Playground/Code/BasicOperations/autoType.cpp
CPP_Playground/Code/BasicOperations/qualifiers.cpp
CPP_Playground/Code/BasicOperations/typeAliases.cpp
CPP_Playground/Code/BasicOperations/primitiveArrays.cpp
CPP_Playground/Code/BasicOperations/functions.cpp
CPP_Playground/Code/Exercises/primeNumbers.cpp
 )

# Link the fmt library with your executable
target_link_libraries(CPP_Executable PRIVATE fmt::fmt)
