Next, we’ll learn about encapsulation. In programming, we often need to control how parts of our program can be accessed and modified, whether it’s to hide sensitive data, ensure that age is always set to a positive integer, or to obscure complex implementation details. The process of hiding grouped data behind a barrier (such as a class definition) and dictating how the data can be accessed and modified is known as encapsulation.
In this lesson we go over how to control access to class memembers using public and private. 
How to control access to fields using properties and automatic properties. 
How to attach members to a class itslef, insted of to its instances using static. 
How to create and use static classes. 

Access Modifers 

Access modifers can be used to prevent other programmers from affecting code that the author wants to be unchanged. I like to think of access modifers like locks on an account. 
There are different access modifers that exists. 

Public modifers mean that the code is usable throughout the project. 
Private means that only code that is in the same class can use the modifers. 
Protected means this code is accessible iwthin the same class that is inherited from that class. 
Internal means the code can only be used within the same assembly.  

Properties are like smart fields or smart variables that are used as a workaround to access modifers. Properties are able to take in values that are passed to them during object instantiation. 
To make a property declare an access modifer type like public or private and specify what data type the property is than use they keywords get and set. 
Getters accept what is. Setters will set what the property will contain based on the value that is passed in. 

Automatic properties have a nice shorthand syntax. 

public class Person (string Name)
{
	private string name; 
	public string Name; 
	{
		get {return name; }
		set {name = value; }
	}
}

class Program
{
	static void Main(string[] args)
	{
		Person myObj = new Person(); 
		myObj.Name = "Liam"; 
		Console.WriteLine(myObj.Name); 
	}
}

The long way of doing things. See how the get method returns the name value and the set value has the name field in the program be set to what value is passed in. 
public string Name 
{
	get {return name;} // get method 
	set {name = value; } // set method
}

public int area;
public int Area
{
  get { return area; }
  set { area = value; }
}


There are specific Techniques that can be utlized with properties. Get-Only Properties will simply grab the value and will have no need of changing anything. 
The other technique is that you can establish what is set as private so that you can control outside influence from affecting your code. 

An example of get only method.

public string Area

{
	get { return area; }
	private set { area = value; }
}

class Book
{
  // Instance property
  public string Title
  { get; set; }

  // Static property
  public static string Definition { get; set; } =  "A connected collection of pages";
}

static void Main(string[] args)
{
  // Outside the Book class, we must access Definition using the class name and dot notation
  Console.WriteLine(Book.Definition);
  // Prints "A connected collection of pages"
}

Static Fields and Properties. 

Static fields and properties are used in classes that are designed to target the class itself. Say you encounter some code that contains a class that was written by someoene else but now you have to make changes to how that class was written. And say the locked the code down. 
Static fields and properties can be created to solve this issue. Static methods are created using the static keyword. Static methods are created by simply adding the static keyword to a method signature. 

public static string Definition {get; set;} // this would be a method signature. 

Within a class definintion you can reference a static member by name alone or using the class name and dot notation. 

By name alone
class Forest
{
    public static int ForestsCreated = 0;
    
    public Forest(string name)
    {
        ForestsCreated++;  // ✅ Direct reference to static member
    }
}

Using class name with dot notaiton.
class Forest
{
    public static int ForestsCreated = 0;
    
    public Forest(string name)
    {
        Forest.ForestsCreated++;  // ✅ Using ClassName.Member
    }
}


Static Methods 

Static methods are methods that affect static classes. 

class Book
{
  // Non-static
  public string Title 
  { get; set; }

  private static string Definition { get; set; } = "A connected collection of pages";
  public static void Define()
  {
    Console.WriteLine(Definition);
  }
}


Static Constructors 

A static constructor is run each time a new instanace of a class is created and typically handles setting values for instance fields and properties. 
We can use a static constructor to handle setup for a class that only needs to be run once before the class is used. Typically, we use static constructors to set values for static fields and properties.

The static constructor of a class will only ever run once during the execution of a program, the first time either one of these events occurs:

    an object is made from the type
    another static member of the class is accessed

class Book
{
  public string Title 
  { get; set; }

  private static string Definition { get; set; } 

  static Book()
  { 
    Definition = "A connected collection of pages";
  }

  public static void Define()
  {
    Console.WriteLine(Definition);
  }
}

A static constructor cannot have an access modifier or take parameters. A class may only have one static constructor, meaning they also cannot be overloaded. Static constructors cannot be called directly — they are only ever called automatically under the conditions specified before.
Labeling a static constructor with private or public produces an error like:

The preceding code sample defines a Book class with a static constructor, which sets the value of the static Definition property.

A static constructor cannot have an access modifier or take parameters. A class may only have one static constructor, meaning they also cannot be overloaded. Static constructors cannot be called directly — they are only ever called automatically under the conditions specified before.

Static memebers are not contained in each object. They only exist in the class. The static members or fields or variables are capable of talking to the class that created them and access their information for the object to use. 
A static constructor cannot have an access modifier or take parameters. A class may only have one static constructor, meaning they also cannot be overloaded. 
Static constructors cannot be called directly — they are only ever called automatically under the conditions specified before.