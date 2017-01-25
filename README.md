# PKod
An esoteric language, that only allows storing in a single double value. With VB.NET interpretor.

## Documentation
(Note: for documentation, # will represent ascii char code for next char in PKod code)
(Note2: when next char is used, next char is ignored / jumped over in the code)

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

## Example code
##### Print all letters from a to z

    =a-+oiz
    
> Sets value as a, removes one from value to make first loop iteration valid, and then loops between +o until value reaches z

##### Print all numbers from 0 to 100

    +nid

> Loops + and n until value is d (which has char code of 100)

##### Print a bunch of random characters, forever

    roiz
    
> Loops r and o until value is z. Value never reaches z, because after r we have o, thus "o-1" or "n" is the max symbol ever reached, which is before z
