# Code examples / sample programs

#### Find closest bigger prime
    jn\+\iÿ?n

    Explanation: jn - Take input of char, set as value and print number
                 \+ - Skip if number is prime (at that point, it just checks if input is prime), and add 1 to value
                 \i - Skip if number is prime, else go back two blocks (and iterate +\i again, till value is prime)
                 ÿ  - Maximum ascii value, of 0xFF or 255 - This means it will check up to 255
                 ?n - Print new line and number (if this is reached, number is prime, so print it)

#### Collatz Conjecture

    gjn?$}3$+a2d1n
    
    
    Explanation: gj - If value is 0, skip next instruction (j). Good way to take input only once.
                 n? - Print number and new line
                 $}3 - If not even, run multipy (}). If multiply is ran, value is multiplied by 3. Else, since 3 means nothing, it does nothing
                 $+ - If not even, add one to value (thus if odd, 3n+1 part is done)
                 a2 - Divide by 2, thus (3n+1)/2 (iteration) is done)
                 d1 - Until value is 1
                 n - Print 1 to make output look complete
