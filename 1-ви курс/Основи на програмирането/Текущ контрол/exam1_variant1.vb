Imports System

Module Program
    Sub Main(args As String())
        Dim testString As String = "20251421036"
        Dim revString As String = StrReverse(testString)
        'Reverse is 63012415202
        '- изисква въвеждане на потребителско име и парола.
        Dim userName, passWord As String
        Console.Write("Input Username: ")
        userName = (Console.ReadLine())
        Console.Write("Input Password: ")
        passWord = (Console.ReadLine())
        '- проверява дали потребителското име съответства на вашия факултетен номер
        If userName = testString Then
            '- проверява дали паролата е вашия факултетен номер, изписан наобратно
            If (passWord = revString) Then
                '  ако паролата е съгласно изискването да се въведе цяло число от клавиатурата, след което.
                Dim a, b, c, n As Integer
                Dim someResult As Double
                Console.Write("Please input whole number: ")
                n = CInt(Console.ReadLine())
                a = CInt(revString.Substring(0, 1))  'Последна цифра
                b = CInt(revString.Substring(1, 1))  'Предпоследна цифра
                c = CInt(revString.Substring(2, 1))  'Предпредпоследна цифра
                'If c = 0 Then
                'Console.WriteLine("Third number from right to left is zero, so I'm picking up the forth one")
                'c = CInt(revString.Substring(3, 1))
                'End If
                '- Съберете числото с последната цифра на вашия факултетен номер
                'someResult = n + a
                '- Умножете резултата с предпоследната цифра на вашия факултетен номер
                'someResult = someResult * b
                '- Полученото число разделете на предпредпоследната (третата от дясно наляво) цифра от факултетния ви номер.
                'someResult = someResult / c
                'или накратко
                someResult = ((n + a) * b) / c
                '- отпечатайте само цялата част на резутата.
                Console.WriteLine("Result is: {0}", Int(someResult))
            End If
            '- ако паролата не е коректна спрямо изискванията да програмата да приключи,
        End If
        '       Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c)
    End Sub
End Module
