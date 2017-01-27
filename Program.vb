Module Module1

    Dim myOnlyValue As Double
    Dim codePos = 0
    Dim rand As New Random()
    Sub Main()
        Console.WriteLine("Interpreter for esoteric language PKod." + Environment.NewLine + "Language made by PKTINOS")
        Console.WriteLine(Environment.NewLine + "Code: (Press enter to execute)")
        codePos = 0
        myOnlyValue = 0
        Dim code As String = Console.ReadLine
        Execute(code)
    End Sub
    Sub Execute(ByVal code As String)
        Console.WriteLine("Output:")
        Try
            Do While codePos <= code.Length - 1
                If (codePos = code.Length - 1) Then
                    Action(code(codePos), Nothing)
                Else
                    Action(code(codePos), code(codePos + 1))
                End If

                codePos += 1
                If codePos = code.Length Then
                    Exit Do
                End If
            Loop

            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("All of the code was executed")
            Console.WriteLine()
            Console.ReadLine()
            Console.Clear()
            Main()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        
    End Sub

    Sub Action(ByVal c As Char, ByVal nextC As Char)
        Try
            'Note: When next char is used, it's skipped in the code

            If (c = "="c) Then
                'Set value as next char
                myOnlyValue = Asc(nextC)
                codePos += 1
                Return
            ElseIf (c = "r"c) Then
                'Set value as random number
                myOnlyValue = rand.Next(Asc(nextC))
            ElseIf (c = "o"c) Then
                'Print corresponding ascii char
                Console.Write(Chr(Math.Round(myOnlyValue)))
            ElseIf (c = "s"c) Then
                'Add next char to the number
                myOnlyValue += Asc(nextC)
                codePos += 1
                Return
            ElseIf (c = "p"c) Then
                'Raises value to power of corresponding ascii char code of next char
                myOnlyValue = Math.Pow(myOnlyValue, Integer.Parse(nextC))
                codePos += 1
                Return
            ElseIf (c = "n"c) Then
                'Writes out value as a number
                Console.Write(myOnlyValue.ToString())
            ElseIf (c = "_"c) Then
                'Tries to parse next char as integer, and adds it to value
                Dim temp As Double = 0
                Integer.TryParse(nextC.ToString(), temp)
                myOnlyValue += temp
                codePos += 1
                Return
            ElseIf (c = "*"c) Then
                'Multiplies value by next char and sets it as new value
                myOnlyValue *= Asc(nextC)
                codePos += 1
                Return
            ElseIf (c = "/"c) Then
                'Multiplies by 1/nextC and sets it as new value
                myOnlyValue *= 1 / Asc(nextC)
                codePos += 1
                Return
            ElseIf (c = "^"c) Then
                'Xors by nextC and sets it as new value
                myOnlyValue = myOnlyValue Xor Asc(nextC)
                codePos += 1
                Return
            ElseIf (c = "%"c) Then
                'Gets remainder by rounded division of value and nextc
                myOnlyValue = Math.Round(myOnlyValue) Mod Asc(nextC)
                codePos += 1
                Return
            ElseIf (c = "i"c) Then
                'Kicks you back 2 blocks in code (3 so it cancels out the addition on the loop) until value is nextC
                If Chr(Math.Round(myOnlyValue)) <> nextC Then
                    codePos -= 3
                    Return
                Else
                    codePos += 1
                End If
            ElseIf (c = "j"c) Then
                'Take input of a char, and set it as value
                myOnlyValue = Asc(Console.ReadKey().KeyChar)
            ElseIf (c = "+"c) Then
                'Adds 1 to the value
                myOnlyValue += 1
            ElseIf (c = "-"c) Then
                'Removes 1 from value
                myOnlyValue -= 1
            ElseIf (c = "!") Then
                'Sleep the thread for next char*1000
                Threading.Thread.Sleep(Integer.Parse(nextC) * 1000)
            ElseIf (c = "z"c) Then
                'Jump to start if next char isnt equal with value
                If (Asc(nextC) <> Math.Round(myOnlyValue)) Then
                    codePos = -1
                Else
                    codePos += 1
                End If
            ElseIf (c = "u") Then
                myOnlyValue = Math.PI
            ElseIf (c = "b") Then
                myOnlyValue = Math.E
            ElseIf (c = "m") Then
                myOnlyValue -= Asc(nextC)
                codePos += 1
                Return
            ElseIf (c = "}") Then
                myOnlyValue *= Integer.Parse(nextC)
                codePos += 1
                Return
            ElseIf (c = "{") Then
                myOnlyValue = Math.Log(myOnlyValue)
                Return
            ElseIf (c = ";") Then
                myOnlyValue = Math.Log10(myOnlyValue)
                Return
            ElseIf (c = ":") Then
                myOnlyValue = Math.Sqrt(myOnlyValue)
                Return
            ElseIf (c = "(") Then
                'Skip next char if not prime
                If isPrime(Math.Round(myOnlyValue)) = False Then
                    codePos += 1
                    Return
                End If
            ElseIf (c = ")") Then
                'Raise e^value
                myOnlyValue = Math.Exp(myOnlyValue)
                Return
            ElseIf (c = "$") Then
                'Skip next char if even
                If myOnlyValue Mod 2 = 0 Then
                    codePos += 1
                    Return
                End If
            ElseIf (c = "e") Then
                'Multiply by 10^nextC's integer, if it exists
                myOnlyValue *= Math.Pow(10, Integer.Parse(nextC))
            ElseIf (c = "<") Then
                'Go back to the start
                codePos = -1
            ElseIf (c = "?") Then
                'Print a newline
                Console.WriteLine()

            ElseIf (c = "q") Then
                myOnlyValue = Environment.TickCount
            ElseIf (c = "~") Then
                If (myOnlyValue Mod 2 = 0) Then
                    Console.Write("True")
                Else
                    Console.Write("False")
                End If
            ElseIf (c = "x") Then
                If (isPrime(Math.Round(myOnlyValue))) Then
                    Console.Write("True")
                Else
                    Console.Write("False")
                End If
            ElseIf (c = ">") Then
                codePos += 1
                Return
            ElseIf (c = "f") Then
                myOnlyValue = Math.Abs(myOnlyValue)
            ElseIf (c = "\") Then
                If isPrime(Math.Round(myOnlyValue)) = True Then
                    codePos += 1
                    Return
                End If
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub
    Public Function isPrime(ByVal number As Integer) As Boolean
        If number = 1 Then
            Return False
        End If
        If number = 2 Then
            Return True
        End If

        Dim boundary = CInt(Math.Floor(Math.Sqrt(number)))

        For i As Integer = 2 To boundary
            If number Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function
End Module
