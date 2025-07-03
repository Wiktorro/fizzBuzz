if (POLICY CMP0048) # see https://cmake.org/cmake/help/latest/policy/CMP0048.html
  cmake_policy(SET CMP0048 NEW) # mute warning about no PROJECT_VERSION provided with project()
endif (POLICY CMP0048)

project(fizzBuzz)
target_include_directories(${PROJECT_NAME} PUBLIC include/)
