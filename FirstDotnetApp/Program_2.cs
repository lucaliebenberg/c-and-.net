using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

internal class Program_2
{
    private static void Main(string[] args)
    {
        // Built-In Types
        // bool myBool = true;

        // byte myByte = 255;
        // sbyte mySbyte = -128;

        // int myInt = 214836542;
        // short myShort = 32767;        
        // long myLong = 9223372036854775807;

        // uint myUint = 4294967295;
        // ushort myUshort = 65535;
        // ulong myUlong = 18446744073709551615;

        // float myFloat = 3.14f;
        // double myDouble = 3.141592653589793;
        // decimal myDecimal = 3.14159265358979323846264338327950288419716939937510582097494459m;

        DateTime myDateTime = DateTime.UtcNow;

        int[] myIntArray = new int[3];

           // named tuple
        var personInfo = (
            Age: 30,
            Name: "Alice",
            IsEmployed: true
        );
        Console.WriteLine(personInfo);

    }

      private static (int Age, string Name) GetEmployee() 
        {
            return (30, "John");
        }

        enum EmployeeType 
        {
            Manager, 
            Supervisor,
            Worker
        }

     

}