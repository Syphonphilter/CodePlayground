# Install script for directory: /Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0

# Set the install prefix
if(NOT DEFINED CMAKE_INSTALL_PREFIX)
  set(CMAKE_INSTALL_PREFIX "/usr/local")
endif()
string(REGEX REPLACE "/$" "" CMAKE_INSTALL_PREFIX "${CMAKE_INSTALL_PREFIX}")

# Set the install configuration name.
if(NOT DEFINED CMAKE_INSTALL_CONFIG_NAME)
  if(BUILD_TYPE)
    string(REGEX REPLACE "^[^A-Za-z0-9_]+" ""
           CMAKE_INSTALL_CONFIG_NAME "${BUILD_TYPE}")
  else()
    set(CMAKE_INSTALL_CONFIG_NAME "Debug")
  endif()
  message(STATUS "Install configuration: \"${CMAKE_INSTALL_CONFIG_NAME}\"")
endif()

# Set the component getting installed.
if(NOT CMAKE_INSTALL_COMPONENT)
  if(COMPONENT)
    message(STATUS "Install component: \"${COMPONENT}\"")
    set(CMAKE_INSTALL_COMPONENT "${COMPONENT}")
  else()
    set(CMAKE_INSTALL_COMPONENT)
  endif()
endif()

# Is this installation the result of a crosscompile?
if(NOT DEFINED CMAKE_CROSSCOMPILING)
  set(CMAKE_CROSSCOMPILING "FALSE")
endif()

# Set default install directory permissions.
if(NOT DEFINED CMAKE_OBJDUMP)
  set(CMAKE_OBJDUMP "/usr/bin/objdump")
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib" TYPE STATIC_LIBRARY FILES "/Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/libfmtd.a")
  if(EXISTS "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/libfmtd.a" AND
     NOT IS_SYMLINK "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/libfmtd.a")
    execute_process(COMMAND "/usr/bin/ranlib" "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/libfmtd.a")
  endif()
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/include/fmt" TYPE FILE FILES
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/args.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/chrono.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/color.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/compile.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/core.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/format.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/format-inl.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/os.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/ostream.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/printf.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/ranges.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/std.h"
    "/Users/syphonphilter/Projects/Playground/CPP_Playground/Utils/fmt-10.1.0/include/fmt/xchar.h"
    )
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/fmt" TYPE FILE FILES
    "/Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/fmt-config.cmake"
    "/Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/fmt-config-version.cmake"
    )
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  if(EXISTS "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/fmt/fmt-targets.cmake")
    file(DIFFERENT _cmake_export_file_changed FILES
         "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/fmt/fmt-targets.cmake"
         "/Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/Export/b834597d9b1628ff12ae4314c3a2e4b8/fmt-targets.cmake")
    if(_cmake_export_file_changed)
      file(GLOB _cmake_old_config_files "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/fmt/fmt-targets-*.cmake")
      if(_cmake_old_config_files)
        string(REPLACE ";" ", " _cmake_old_config_files_text "${_cmake_old_config_files}")
        message(STATUS "Old export file \"$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/fmt/fmt-targets.cmake\" will be replaced.  Removing files [${_cmake_old_config_files_text}].")
        unset(_cmake_old_config_files_text)
        file(REMOVE ${_cmake_old_config_files})
      endif()
      unset(_cmake_old_config_files)
    endif()
    unset(_cmake_export_file_changed)
  endif()
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/fmt" TYPE FILE FILES "/Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/Export/b834597d9b1628ff12ae4314c3a2e4b8/fmt-targets.cmake")
  if(CMAKE_INSTALL_CONFIG_NAME MATCHES "^([Dd][Ee][Bb][Uu][Gg])$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/fmt" TYPE FILE FILES "/Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/CMakeFiles/Export/b834597d9b1628ff12ae4314c3a2e4b8/fmt-targets-debug.cmake")
  endif()
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/pkgconfig" TYPE FILE FILES "/Users/syphonphilter/Projects/Playground/build/CPP_Playground/Utils/fmt-10.1.0/fmt.pc")
endif()

