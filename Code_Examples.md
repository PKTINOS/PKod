# Code examples / sample programs

#### Find next prime

    +\<n

    Explanation: +\< - Add to value until number is prime (increment check_if_prime(true->skip next char false->loop))
                 n - Print value

#### Collatz Conjecture

    n?$}3$+a2d1n
    
    Explanation: n? - Print value and new line
                 $}3 - If not even, run multiply (}). If multiply is ran, value is multiplied by 3. Else, since 3 means nothing, it does nothing
                 $+ - If not even, add one to value (thus if odd, 3n+1 part is done)
                 a2 - Divide by 2, thus (3n+1)/2 (iteration) is done)
                 d1 - Until value is 1
                 n - Print 1 to make output look complete

#### Print letters from a to z

    =a-+oiz
    
    Explanation: =a - set value as a
                 -  - decrement value by 1
                 +o - increment value by 1, and print value
                 iz - loop two previous instructions until value is z

#### [Loading... Forever][1]

    lL=oo=ao=do=io=no=go=.ooo =|oyw=/oyw=-oyw=\oywl<
    
    Explanation: l - Clear screen and since its the first char, allow printing no operation (NOP) chars
                 L - NOP, thus print "L"
                 =oo=ao=do=io=no=go=.ooo - Set as certain chars and print them.
                 (space) - Another NOP, thus print a space
                 =|oyw - Set char as "|", print it, then wait a quarter of a second and remove it
                 =/oyw=-oyw=\oywl - Same as above, with different symbols to match the challenge
                 < - Go back to the start

[1]:http://codegolf.stackexchange.com/questions/101289/loading-forever

#### [Blinking twelve][2]

    l12=:o00yyl=-oo=:o=-ooyy<

    Explanation:
    l - if first char in code, print any NOP chars found
    12 - two NOP chars to print
    =: - set variable as :
    o - print variable's corresponding ascii char
    y - wait 0.25 seconds
    l - if not first char in code, clear the console
    =-oo - set variable as - and print twice
    < - go back to the start of the code

[2]:https://codegolf.stackexchange.com/questions/105323/blinking-twelve
