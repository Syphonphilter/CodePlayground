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
include CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/compiler_depend.make

# Include the progress variables for this target.
include CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/progress.make

# Include the compile flags for this target's objects.
include CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/flags.make

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.o: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/flags.make
CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.o: /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/format.cc
CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.o: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --progress-dir=/Users/syphonphilter/Projects/Playground/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.o"
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && /usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.o -MF CMakeFiles/fmt.dir/src/format.cc.o.d -o CMakeFiles/fmt.dir/src/format.cc.o -c /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/format.cc

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Preprocessing CXX source to CMakeFiles/fmt.dir/src/format.cc.i"
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && /usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/format.cc > CMakeFiles/fmt.dir/src/format.cc.i

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Compiling CXX source to assembly CMakeFiles/fmt.dir/src/format.cc.s"
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && /usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/format.cc -o CMakeFiles/fmt.dir/src/format.cc.s

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.o: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/flags.make
CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.o: /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/os.cc
CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.o: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --progress-dir=/Users/syphonphilter/Projects/Playground/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Building CXX object CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.o"
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && /usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.o -MF CMakeFiles/fmt.dir/src/os.cc.o.d -o CMakeFiles/fmt.dir/src/os.cc.o -c /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/os.cc

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Preprocessing CXX source to CMakeFiles/fmt.dir/src/os.cc.i"
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && /usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/os.cc > CMakeFiles/fmt.dir/src/os.cc.i

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Compiling CXX source to assembly CMakeFiles/fmt.dir/src/os.cc.s"
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && /usr/bin/clang++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/src/os.cc -o CMakeFiles/fmt.dir/src/os.cc.s

# Object files for target fmt
fmt_OBJECTS = \
"CMakeFiles/fmt.dir/src/format.cc.o" \
"CMakeFiles/fmt.dir/src/os.cc.o"

# External object files for target fmt
fmt_EXTERNAL_OBJECTS =

CPP_Playground/Utils/fmt-10.1.0/libfmtd.a: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/format.cc.o
CPP_Playground/Utils/fmt-10.1.0/libfmtd.a: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/src/os.cc.o
CPP_Playground/Utils/fmt-10.1.0/libfmtd.a: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/build.make
CPP_Playground/Utils/fmt-10.1.0/libfmtd.a: CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --bold --progress-dir=/Users/syphonphilter/Projects/Playground/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_3) "Linking CXX static library libfmtd.a"
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && $(CMAKE_COMMAND) -P CMakeFiles/fmt.dir/cmake_clean_target.cmake
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && $(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/fmt.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/build: CPP_Playground/Utils/fmt-10.1.0/libfmtd.a
.PHONY : CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/build

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/clean:
	cd /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 && $(CMAKE_COMMAND) -P CMakeFiles/fmt.dir/cmake_clean.cmake
.PHONY : CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/clean

CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/depend:
	cd /Users/syphonphilter/Projects/Playground/build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /Users/syphonphilter/Projects/Playground /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0 /Users/syphonphilter/Projects/Playground/build /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0 /Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/DependInfo.cmake "--color=$(COLOR)"
.PHONY : CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/fmt.dir/depend

