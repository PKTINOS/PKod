# Code examples / sample programs

#### Find closest bigger prime
    n\+\iÿ?n

    Explanation: n - Print value (will print input)
                 \+ - Skip if number is prime (at that point, it just checks if input is prime), and add 1 to value
                 \i - Skip if number is prime, else go back two blocks (and iterate +\i again, till value is prime)
                 ÿ  - Maximum ascii value, of 0xFF or 255 - This means it will check up to 255
                 ?n - Print new line and number (if this is reached, number is prime, so print it)

#### Collatz Conjecture

    n?$}3$+a2d1n
    
    Explanation: n? - Print value and new line
                 $}3 - If not even, run multipy (}). If multiply is ran, value is multiplied by 3. Else, since 3 means nothing, it does nothing
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
    
    Explanation: l - Clear screen
                 L - NOP, thus print "L"
                 =oo=ao=do=io=no=go=.ooo - Set as certain chars and print them.
                 (space) - Another NOP, thus print a space
                 =|oyw - Set char as "|", print it, then wait a quarter of a second and remove it
                 =/oyw=-oyw=\oywl - Same as above, with different symbols to match the challenge
                 < - Go back to the start

[1]:http://codegolf.stackexchange.com/questions/101289/loading-forever