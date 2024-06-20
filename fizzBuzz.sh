#!/usr/bin/env bash

## useful infos at https://linuxsimply.com/bash-scripting-tutorial/conditional-statements/if/modulo-if/ 

re='^[0-9]+([.][0-9]+)?$' ##numeric with possible decimal fractions

FizzBuzz () {
    
if [[ ! $1 =~ $re ]] ; then 
	echo "wrong data $1 " ; return 1 ## must be if-fi instead && || for a proper exit fcn
fi

local remainder3=$(( $1 % 3))
local remainder5=$(( $1 % 5))
echo " for $1 :: ${remainder3} ${remainder5} "

 if [[ ${remainder3} -eq  0 ]] ; then 
 [[ ${remainder5} -eq  0 ]] && echo "FizzBuzz" ||   echo "Fizz" 
  elif [[ ${remainder5} -eq  0 ]] ; then 
    echo "Buzz" 
  else 
    echo "$1" 
  fi
return 0 ; 
}

FizzBuzz 0 
FizzBuzz 3 
FizzBuzz 7 
FizzBuzz 10 
FizzBuzz 15
FizzBuzz "bbb"
FizzBuzz "$1"
