using System;

class Program {
    public void RemoveLastCharacter(string value)
    {
        if(string.IsNullOrEmpty(value))
        {
            Console.WriteLine("Null");
        }
        else
        {
            string newString = value.Substring(0, value.Length -1);
            Console.WriteLine(newString);
                
        }
    }
    public static void Main()
    {
        Program withoutLast = new Program();
        withoutLast.RemoveLastCharacter("Samson");
    }
}