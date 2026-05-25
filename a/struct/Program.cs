using System;

struct book
{
    public string title;
    public string author;
    public int year;
    public bool isavailable;

    public book(string title, string author, int year, bool isavailable)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.isavailable = isavailable;
    }

    public void getinfo()
    {
        Console.WriteLine($"{title} by {author}, {year} - {isavailable}/Chrcked out");
    }
}

class Program
{
    static void Main()
    {
        book[] books = new book[3];
        book[3];
        for(int i = 0; i < 3; i++)
        {
            Console.Write("Введите название книги для заполнения: ");
            book[i] = Console.ReadLine("");
        }
        Console.Write("Введите название книги для поиска: ");
        string a = Console.ReadLine("");
        for(int i = 0; i < 3; i++)
        {
            if(searchTitle == books[i].Title)
            {
                books[i].GetInfo();
            }
        }
    }
}
