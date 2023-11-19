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
CPP_Playground/Code/main.cpp
CPP_Playground/Code/pointers.cpp
CPP_Playground/Code/iterations.cpp
 )

# Link the fmt library with your executable
target_link_libraries(CPP_Executable PRIVATE fmt::fmt)
