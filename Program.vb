Module Module1

   'PKod. An esoteric language made by PKTINOS

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
                    Exit Do
                End If
                Action(code(codePos), code(codePos + 1))
                codePos += 1
            Loop
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
                myOnlyValue = Math.Pow(myOnlyValue, Asc(nextC))
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
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub
End Module
