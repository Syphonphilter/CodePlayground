# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.27

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Disable VCS-based implicit rules.
% : %,v

# Disable VCS-based implicit rules.
% : RCS/%

# Disable VCS-based implicit rules.
% : RCS/%,v

# Disable VCS-based implicit rules.
% : SCCS/s.%

# Disable VCS-based implicit rules.
% : s.%

.SUFFIXES: .hpux_make_needs_suffix_list

# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/local/Cellar/cmake/3.27.8/bin/cmake

# The command to remove a file.
RM = /usr/local/Cellar/cmake/3.27.8/bin/cmake -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /Users/syphonphilter/Projects/Playground

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /Users/syphonphilter/Projects/Playground/build

# Include any dependencies generated for this target.
include CMakeFiles/CPP_Executable.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include CMakeFiles/CPP_Executable.dir/compiler_depend.make

# Include the progress variables for this target.
include CMakeFiles/CPP_Executable.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/CPP_Executable.dir/flags.make

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o: CMakeFiles/CPP_Executable.dir/flags.make
CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o: /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/main.cpp
CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o: CMakeFiles/CPP_Executable.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --progress-dir=/Users/syphonphilter/Projects/Playground/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o -MF CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o.d -o CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o -c /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/main.cpp

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Preprocessing CXX source to CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.i"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/main.cpp > CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.i

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Compiling CXX source to assembly CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.s"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/main.cpp -o CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.s

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o: CMakeFiles/CPP_Executable.dir/flags.make
CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o: /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/pointers.cpp
CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o: CMakeFiles/CPP_Executable.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --progress-dir=/Users/syphonphilter/Projects/Playground/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Building CXX object CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o -MF CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o.d -o CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o -c /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/pointers.cpp

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Preprocessing CXX source to CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.i"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/pointers.cpp > CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.i

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Compiling CXX source to assembly CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.s"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/pointers.cpp -o CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.s

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o: CMakeFiles/CPP_Executable.dir/flags.make
CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o: /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/iterations.cpp
CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o: CMakeFiles/CPP_Executable.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --progress-dir=/Users/syphonphilter/Projects/Playground/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_3) "Building CXX object CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o -MF CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o.d -o CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o -c /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/iterations.cpp

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Preprocessing CXX source to CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.i"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/iterations.cpp > CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.i

CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Compiling CXX source to assembly CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.s"
	/usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/syphonphilter/Projects/Playground/CPP_Playground/Code/iterations.cpp -o CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.s

# Object files for target CPP_Executable
CPP_Executable_OBJECTS = \
"CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o" \
"CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o" \
"CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o"

# External object files for target CPP_Executable
CPP_Executable_EXTERNAL_OBJECTS =

CPP_Executable: CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/main.cpp.o
CPP_Executable: CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/pointers.cpp.o
CPP_Executable: CMakeFiles/CPP_Executable.dir/CPP_Playground/Code/iterations.cpp.o
CPP_Executable: CMakeFiles/CPP_Executable.dir/build.make
CPP_Executable: CPP_Playground/Utils/fmt-10.1.0/libfmtd.a
CPP_Executable: CMakeFiles/CPP_Executable.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --bold --progress-dir=/Users/syphonphilter/Projects/Playground/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_4) "Linking CXX executable CPP_Executable"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/CPP_Executable.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/CPP_Executable.dir/build: CPP_Executable
.PHONY : CMakeFiles/CPP_Executable.dir/build

CMakeFiles/CPP_Executable.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/CPP_Executable.dir/cmake_clean.cmake
.PHONY : CMakeFiles/CPP_Executable.dir/clean

CMakeFiles/CPP_Executable.dir/depend:
	cd /Users/syphonphilter/Projects/Playground/build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /Users/syphonphilter/Projects/Playground /Users/syphonphilter/Projects/Playground /Users/syphonphilter/Projects/Playground/build /Users/syphonphilter/Projects/Playground/build /Users/syphonphilter/Projects/Playground/build/CMakeFiles/CPP_Executable.dir/DependInfo.cmake "--color=$(COLOR)"
.PHONY : CMakeFiles/CPP_Executable.dir/depend

