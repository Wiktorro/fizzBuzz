CC = g++  # Compiler ## to avoid calls like g++ -B . OrderCache.h ##.cpp
CFLAGS = -g -Wno-error #  -Wall # Compiler flags
SRCS = fizzBuzz.cpp  


OBJS = $(SRCS:.cpp=.o)  # Object files
TARGET =  fizzBuzz # Executable name ##

## ALL FORMULAS MUST START WITH SINGLE TAB

default: $(TARGET)
all: $(TARGET)

$(TARGET): $(OBJS)
	$(CC) $(CFLAGS) -o $@ $^

%.o: %.cpp
	$(CC) $(CFLAGS) -c $< -o $@

run: $(TARGET)
	./$(TARGET).o
clean:
	rm -f $(OBJS) $(TARGET)

test: $(TARGET)
	echo 1 | ./$(TARGET).o
	echo 15 | ./$(TARGET).o

runclean: clean all run

testclean: clean $(TARGET) test
