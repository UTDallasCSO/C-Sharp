using System;

public struct Book
{
    public int bookid;
    public string bookname;
    public string authorname;
    public int isbn;
}

public class library
{
    public static void books(string[] args)
    {
        Book book1;
        book1.bookid = 1234;
        book1.bookname = "Harry Potter";
        book1.authorname = "J K Rowling";
        book1.isbn = 65786383;
        Console.WriteLine("Book id: {0}", book1.bookid);
        Console.ReadKey();
    }
    
    
}