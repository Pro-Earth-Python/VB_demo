Imports System.Linq
Imports System.Collections.Generic

'You will learn about frameworks and modules that allow you to access
'new commands/functions 
Module Program
    Public Const pi As Decimal = 3.142
    Sub Main(args As String())
        'open single quote for comments

        'Dim name As String ' varible declartion
        'Dim surname As String
        ''console is a command or a method of a class so 
        'Console.WriteLine("Please enter your name")
        'name = Console.ReadLine()
        'Console.WriteLine("Please enter your surname")
        'surname = Console.ReadLine()
        'Console.WriteLine("Hi my name is :" + name + " and my surname is :" + surname)
        ''calling of a function/sub in VB.NET
        '' test()
        'intro(name, surname)
        ''read_list()
        discount()


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

    Sub discount()
        Console.WriteLine("Welcome to St.Marks The customer policy is to give discounts to all members by age")
        Console.WriteLine("if you are anywhere between the ages of 18 and 34, you have a 10%")
        Console.WriteLine("if you are between the ages of 35 and 59 you get a 30% ")
        Console.WriteLine("if you are between the ages of 59 and older you get a 50% ")

        Dim age As Int32


        Do While age < 70
            Console.WriteLine("Please input your age:")
            age = Console.ReadLine()

            If age = 18 Or age < 34 Then
                Console.WriteLine("Your age a gives you a 10% discount")
            ElseIf age = 35 Or age < 59 Then
                Console.WriteLine("Your age gives you a 30% discount")
            ElseIf age >= 60 Then
                Console.WriteLine("your age gives you a 50% discount")


            End If
        Loop

        Console.ReadKey()


    End Sub

    Sub Collections()
        'A list of different datatypes
        Dim myArrayList As New ArrayList()
        myArrayList.Add("Hello")
        myArrayList.Add(42)
        myArrayList.Add(DateTime.Now)

        'A list of one datatypes
        Dim myList As New List(Of String)()
        myList.Add("Apple")
        myList.Add("Banana")
        myList.Add("Cherry")
        'A list of dictionary values  defined datatypes define dict key and value 
        Dim myDictionary As New Dictionary(Of Integer, String)()
        myDictionary.Add(1, "One")
        myDictionary.Add(2, "Two")
        myDictionary.Add(3, "Three")
        'First in first out Queue
        Dim myQueue As New Queue(Of String)()
        myQueue.Enqueue("First")
        myQueue.Enqueue("Second")
        myQueue.Enqueue("Third")
        'Last in first out stack
        Dim myStack As New Stack(Of String)()
        myStack.Push("First")
        myStack.Push("Second")
        myStack.Push("Third")



    End Sub
End Module