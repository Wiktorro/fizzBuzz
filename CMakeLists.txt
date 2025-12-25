# Specify the minimum version of CMake required
cmake_minimum_required(VERSION 3.10)

if (POLICY CMP0048) # see https://cmake.org/cmake/help/latest/policy/CMP0048.html
  cmake_policy(SET CMP0048 NEW) # mute warning about no PROJECT_VERSION provided with project()
endif (POLICY CMP0048)

# Set the project name and specify the language
project(fizzBuzz LANGUAGES C)
# target_include_directories(${PROJECT_NAME} PUBLIC include/)


set(CMAKE_RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/bin")
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/lib")
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/lib")


# Add the executable target
add_executable(${PROJECT_NAME} fizzBuzz.c)