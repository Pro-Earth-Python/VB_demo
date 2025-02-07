Imports System.Linq
Imports System.Collections.Generic

'You will learn about frameworks and modules that allow you to access
'new commands/functions 
Module Program
    Public Const pi As Decimal = 3.142
    Sub Main(args As String())
        'open single quote for comments

        Dim name As String ' varible declartion
        Dim surname As String
        'console is a command or a method of a class so 
        Console.WriteLine("Please enter your name")
        name = Console.ReadLine()
        Console.WriteLine("Please enter your surname")
        surname = Console.ReadLine()
        Console.WriteLine("Hi my name is :" + name + " and my surname is :" + surname)
        'calling of a function/sub in VB.NET
        test()
        intro(name, surname)
        read_list()


    End Sub
    'no parameters in this sub/function
    Sub test()
        Console.WriteLine("exmaple of calling a method/function/subprocess in VB")
    End Sub
    'paramters in sub/function 
    Sub intro(name, surname)
        Console.WriteLine("hello " + name + " " + " " + surname)
    End Sub
    Sub read_list()
        Dim list_values As New List(Of String) From
            {"Mo", "Jan", "Matt"}

        Console.WriteLine(list_values)
        For Each name In list_values
            Console.WriteLine(name)
        Next



    End Sub
End Module

