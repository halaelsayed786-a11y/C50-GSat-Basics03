/*#region
//Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change. 

Console.WriteLine(" Q1 ");
string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);       
Console.WriteLine(upperTitle);  
#endregion*/

#region 2
//Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory. 
Console.WriteLine(" Q2 ");
string s1 = "Clean Code";
string s2 = "Clean Code";
Console.WriteLine(ReferenceEquals(s1, s2));

#endregion