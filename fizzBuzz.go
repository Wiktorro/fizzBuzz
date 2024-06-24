/******************************************************************************
Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
package main
import (
    "fmt"
    "strconv"
//  github projects can be loaded directly, theoreticaly
// "github.com/stretchr/testify/assert"
// 	homedir "github.com/mitchellh/go-homedir"
// 	"github.com/spf13/cobra"
// 	"github.com/spf13/viper"
)

func FizzBuzz(input uint) string {
    var rem3 = uint8(input%3)
    var rem5 = uint8(input%5)
    if rem3 == 0 {
        if rem5 ==0 {
            return "FizzBuzz"
        } else {
            return "Fizz"
        }
    }
    // if rem3 == 0 {     }
    if rem5 == 0 {
        return "Buzz"
    }
    return strconv.Itoa(int(input))
}

func main() {
    for i := uint(1); i <= 20; i++ {
        fmt.Println(FizzBuzz(i))
    }
}
