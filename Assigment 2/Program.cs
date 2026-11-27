/*#region
//Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change. 

Console.WriteLine(" Q1 ");
string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);       
Console.WriteLine(upperTitle);  
#endregion*/

/*#region 2
//Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory. 
Console.WriteLine(" Q2 ");
string s1 = "Clean Code";
string s2 = "Clean Code";
Console.WriteLine(ReferenceEquals(s1, s2));

#endregion*/

/*#region 3

//Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
using System.Text;

Console.WriteLine(" Q3 ");
StringBuilder sb = new StringBuilder();
sb.Append("Book List");
Console.WriteLine(sb.ToString()); 
#endregion*/


/*#region 4
//Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
Console.WriteLine(" Q4 ");
string title = "Clean Code";
int pages = 464;

string sentence = "Book: " + title + ", Pages: " + pages;

Console.WriteLine(sentence);

#endregion*/

/*#region 5
//Build the same sentence as above, but using string interpolation ($"..."). 
Console.WriteLine(" Q5 ");
string title = "Clean Code";
int pages = 464;

string sentence = $"Book: {title}, Pages: {pages}";

Console.WriteLine(sentence);
#endregion*/

/*#region 6
//Build the same sentence again, but using string.Format(). 
Console.WriteLine(" Q6 ");
string title = "Clean Code";
int pages = 464;

string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);

Console.WriteLine(sentence);
#endregion*/

/*#region 7
//Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".

Console.WriteLine(" Q7 ");
int pages = 464;
if (pages > 300)
    Console.WriteLine("Long Book");
else
    Console.WriteLine("Short Book");
#endregion*/

/*#region 8
//Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailab0le is true. Use the && operator. 

Console.WriteLine(" Q8 ");
int pages = 464;
bool isAvailable = true;
if (pages > 300 && isAvailable)
    Console.WriteLine("You can borrow this book");
#endregion*/

/*#region 9
//Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else. 

Console.WriteLine(" Q9 ");
string t = "Refactoring";
switch (t)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heard of it");
        break;
}
#endregion*/

/*#region 10
//Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300). 

Console.WriteLine(" Q10 ");
int pages = 464;
string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
Console.WriteLine(sizeLabel);

#endregion*/

/*#region 11
//Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code. 
Console.WriteLine(" Q11 ");
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}
#endregion*/

/*#region 12
//Using the same books array, use a while loop to print every book title. 
Console.WriteLine(" Q12 ");
int index = 0;
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


while (index < books.Length)
{
    Console.WriteLine(books[index]);
    index++;
}
#endregion*/

/*#region 13
//Write a do-while loop that prints "Checking book..." exactly 3 times. 

Console.WriteLine(" Q13 ");
int count = 0;
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

do
{
    Console.WriteLine("Checking book...");
    count++;
} while (count < 3);


Console.WriteLine(" Q13 ");
foreach (string book in books)
{
    Console.WriteLine(book);
}


Console.WriteLine(" Q13 ");
foreach (string book in books)
{
    if (book == "Refactoring")
        break;
    Console.WriteLine(book);
}
#endregion*/

#region 14
//Using the same books array, use a foreach loop to print every book title. 

Console.WriteLine(" Q14 ");
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

foreach (string book in books)
{
    Console.WriteLine(book);

}
#endregion