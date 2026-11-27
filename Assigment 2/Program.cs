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

#region 5
//Build the same sentence as above, but using string interpolation ($"..."). 
Console.WriteLine(" Q5 ");
string title = "Clean Code";
int pages = 464;

string sentence = $"Book: {title}, Pages: {pages}";

Console.WriteLine(sentence);
#endregion