'''

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

'''

def FizzBuzz(num : int) -> str:
    rem3: Final[int] = num % 3 ## variables intented as const, warned by static check
    rem5: Final[int] = num % 5
    if rem3 == 0:
        if rem5 == 0:
            return('Fizzbuzz')
        else: #elif num % 5 != 0:
            return('Fizz')
    elif rem5 == 0:
        return('Buzz')
    else:
        return num

def main():
    print ('Hello World')
    print(f"{FizzBuzz(3)=}")
    print(f"{FizzBuzz(5)=}")
    print(f"{FizzBuzz(30)=}")
    print(f"{FizzBuzz(1)=}")
    for i in range(7):
        print(f"Looped FizzBuzz({i}) = {FizzBuzz(i)}")
    
if __name__ == "__main__":
    # a=int(input('Enter a number: '))
    main()

