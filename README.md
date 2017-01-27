# PKod
An esoteric language, that only allows storing just a single number.

## Documentation
(Note: for documentation, # will represent ascii char code for next char in PKod code)

(Note2: when next char is used, next char is ignored / jumped over in the code)

(Note3: "value" is reffering to the only data type you can read/store to in PKod)

(Note4: obviously, when # is parsed as integer, it can only take values from 0-9)

 - =# Sets value as #
 - r# Sets value as random number between 0 and # minus 1
 - o  Prints value's corresponding char
 - n  Prints value as a string
 - s# Adds # to the value
 - p# Raises value to #
 - \_# Tries to parse #'s char as an integer, if it can, it adds it to the value.
 - \*# Multiplies value by #
 - /# Multiplies value by 1/#
 - ^# Xors value and #
 - %# Mods value by #
 - i# If value is not equal with #, it kicks you back two blocks in the code
 - j  Take input of a char, set it as value
 - +  Add 1 to value
 - \- Remove 1 from value
 - !  Sleep thread for int.Parse(#) * 1000
 - z# Jump back to the start if value isnt #
 - u  Set value as PI
 - b  Set value as Eulers Number E
 - m# Remove # from value
 - }# Try to parse # as an integer, multiply by value and set as new value
 - {  Set value as Ln(value) (the natural, base E logarithm of value)
 - ;  Set value as Log(value) (base 10 logarithm of value)
 - :  Set value as sqrt(value) (value ^ 1/2)
 - (  Skip next char in code, if value is not a prime number
 - \\  Skip next char in code, if value is a prime number
 - )  Set value as E^value
 - $  Skip next char if value is even
 - e# Try to parse # as integer, then set value as value * 10^int(#)
 - <  Jump back to the start
 - ?  Prints a new line
 - q  Gets tickcount, and sets it as value
 - ~  Output true if value is even, else false
 - x  Output true if value is prime, else false
 - >  Skip next char
 - f  Set value as absolute(value)
 - g  Skip next char if value isnt 0
 - d  If value isnt int.parse(#), goto start
