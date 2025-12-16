########## C#
enable_language(CSharp)

cmake_minimum_required(VERSION 3.8) #from https://cmake.org/cmake/help/latest/command/enable_language.html
project(fizzBuzzCs LANGUAGES CSharp VERSION 1.0.0)

# Set the C# standard (optional, depends on compiler support)
set(CMAKE_CSharp_FLAGS "/langversion:latest")

# Add the executable
add_executable(HelloCSharp
    fizzBuzz.cs
)

# Optional: Set output directory
set_target_properties(HelloCSharp PROPERTIES
    RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/binCs"
)

# Optional: Reference external assemblies (example: System.Windows.Forms)
target_link_libraries(HelloCSharp PRIVATE System.Windows.Forms)