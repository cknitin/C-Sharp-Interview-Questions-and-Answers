# Encapsulation
Encapsulation is concept of binding or grouping the data member and member functions in to a single unit as a class.

Real life example is ATM machine

Data member  = Cash
Member functions = Withdraw, Balance check, Last 3 transaction etc.

all the above data members and functions are wrap in a single unit is called ATM machine. 
 

# Data Hiding
Data and encapsulation is the most striking feature of a class. The data is not accessible to the outside world, and only those functions which are wrapped in the class can access it. These functions provide the interface between the object’s data and the program. This insulation of the data from direct access by the program is called data hiding or information hiding. Data Hiding is concept of protecting the data member and member function from access of outside the class. In other words we can not access the data member and member functions outside the class. Data hiding can be controlled using the access modifiers that prefix the class name, method and fields 

# Abstraction 
It's refers to the act of representing essential features without including the background details or explanation. 

# Inheritance 
It's the process by which objects of one class acquired the properties of objects of another classes. It supports the concept of hierarchical classification. In OOP, the concept of inheritance provides the idea of reusability. This means that we can add additional features to an existing class without modifying it


# Polymorphism
It's is another important OOP concept. Polymorphism, a Greek term, means the ability to take more than one form. 
An operation may exhibit different behavior is different instances. The behavior depends upon the types of data used in the operation.
For example, consider the operation of addition. For two numbers, the operation will generate a sum. If the operands are strings, then the operation would produce a third string by concatenation. The process of making an operator to exhibit different behaviors in different instances is known as operator overloading.

In C# how can we achive "Polymorphism"

Polymorphism is a feature of object-oriented programming. It allows you to invoke methods of a derived class through base class reference during runtime. In polymorphism, we will declare methods with same name and different parameters in same class or methods with same name and same parameters in different classes.

Polymorphism has the ability to provide the different implementation of methods that are implemented with the same name.

Type of Polymorphism

1. COMPILE TIME POLYMORPHISM (EARLY BINDING OR OVERLOADING OR STATIC BINDING)

Compile time polymorphism means we will declare a method with same name and different parameter/signature because of this we will perform different tasks with same method name in the same class is called compile time polymorphism.


    class Sample
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b +c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.Sum(10, 20);
            sample.Sum(10, 20, 30);
        }
    }



2. RUNTIME POLYMORPHISM (LATE BINDING OR OVERRIDING OR DYNAMIC BINDING)

Runtime polymorphism means we will declare a method with same name and same parameter/signature in the different class is called runtime polymorphism.

In the runtime polymorphism we can override a method in base class by creating a similar function in derived class this can be achieved by using inheritance principle and using virtual & override keywords. We can declare methods with the virtual keyword then you can override those methods using virtual keyword in the derived class.

    class Parent
    {
        public void Display()
        {
            Console.WriteLine("This is a parent method.");
        }
    }

    class Child : Parent
    {
        public void Display()
        {
            Console.WriteLine("This is a parent method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();

            p.Display();

            Console.ReadKey();
        }
    }

Output # 
This is a parent method.

To Fix that use the virtual and override.

    class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("This is a parent method.");
        }
    }

    class Child : Parent
    {
        public override void Display()
        {
            Console.WriteLine("This is a child method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();

            p.Display();

            Console.ReadKey();
        }
    }



# What is the difference between “dispose” and “finalize” variables in C#?
Dispose - This method uses interface – “IDisposable” interface and it will free up both managed and unmanaged codes like – database connection, files etc.

Finalize - This method is called internally unlike Dispose method which is called explicitly. It is called by garbage collector and can’t be called from the code.

# What is the difference between “finalize” and “finally” methods in C#?
Finalize – This method is used for garbage collection. So before destroying an object this method is called as part of clean up activity.

Finally – This method is used for executing the code irrespective of exception occurred or not.

# What is the difference between “throw ex” and “throw” methods in C#?

“throw ex” will replace the stack trace of the exception with stack trace info of re throw point.
“throw” will preserve the original stack trace info.

# Can we use “this” inside a static method in C#?
No. We can’t use “this” in static method.

# Explain String Builder class in C#?
This will represent the mutable string of characters and this class cannot be inherited. It allows us to Insert, Remove, Append and Replace the characters. “ToString()” method can be used for the final string obtained from StringBuilder. For example,

StringBuilder TestBuilder = new StringBuilder("Hello");

TestBuilder.Remove(2, 3); // result - "He"

TestBuilder.Insert(2, "lp"); // result - "Help"

TestBuilder.Replace('l', 'a'); // result - "Heap"



What is the difference between “StringBuilder” and “String” in C#?

StringBuilder is mutable, which means once object for stringbuilder is created, it later be modified either using Append, Remove or Replace.

String is immutable and it means we cannot modify the string object and will always create new object in memory of string type.

# What is the difference between methods – “System.Array.Clone()” and “System.Array.CopyTo()” in C#?
“CopyTo()” method can be used to copy the elements of one array to other. 
“Clone()” method is used to create a new array to contain all the elements which are in the original array.

# How we can sort the array elements in descending order in C#?
To Sort an array, use OrderByDescending method and then “Reverse()” to sort the array in descending order.

    int[] x =  {3,1,6,7,3,2,5,7};
    try
    { 
         x = x.OrderByDescending(r => r).Reverse().ToArray();
         foreach (var item in x)
         {
             Console.WriteLine(item);
         }
     }
     catch (Exception ex)
     {
         throw;
    }

# Find the index of item in array

    int[] x =  {3,1,6,7,3,2,5,7};
    int index = Array.IndexOf(x, 5); // answer : 6
    int index = Array.IndexOf(x, 17); // anwser : -1
    Console.WriteLine(index);

# Explain object pool in C#?
Object pool is used to track the objects which are being used in the code. So object pool reduces the object creation overhead.

# What you mean by delegate in C#?
Delegates are type safe pointers unlike function pointers as in C++. Delegate is used to represent the reference of the methods of some return type and parameters.

# What are the types of delegates in C#?
Below are the uses of delegates in C# -
Single Delegate
Multicast Delegate
Generic Delegate

#What are the three types of Generic delegates in C#?
These are three types of generic delegates in C# -
Func
Action
Predicate

# What are the uses of delegates in C#?
Below are the list of uses of delegates in C# -
Callback Mechanism

Asynchronous Processing
Abstract and Encapsulate method
Multicasting

# Can we use delegates for asynchronous method calls in C#?
Yes. We can use delegates for asynchronous method calls.

# Why to use “Nullable Coalescing Operator” (??) in C#?
Nullable Coalescing Operator can be used with reference types and nullable value types. So if the first operand of the expression is null then the value of second operand is assigned to the variable. For example,

double? myFirstno = null;

double mySecno;

mySecno = myFirstno ?? 10.11;

# What is the difference between “as” and “is” operators in C#?
“as” operator is used for casting object to type or class.
“is” operator is used for checking the object with type and this will return a Boolean value.

# What you mean by boxing and unboxing in C#?
Boxing – This is the process of converting from value type to reference type. For example,
int myvar = 10;
object myObj = myvar;

UnBoxing – It’s completely opposite to boxing. It’s the process of converting reference type to value type. For example,
int myvar2 = (int)myObj;

# Explain Partial Class in C#?
Partial classes concept added in .Net Framework 2.0 and it allows us to split the business logic in multiple files with the same class name

# Shallow Copy
  
    class Demo
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public Demo Copy()
       {
           return (Demo)this.MemberwiseClone();
       }
       public void Print(string objectName)
       {
           Console.WriteLine($"Object Name- {objectName} \nFirst Name- {FirstName} \nLast Name- {LastName}");
       }
    }

    class Program
    {
       static void Main(string[] args)
       {
         Demo d1 = new Demo();
         d1.FirstName = "Peter";
         d1.LastName = "Parker";
         d1.Print("d1");

         Demo d2 = new Demo();
         d2 = d1.Copy();
         d2.FirstName = "Rachel";
         d2.Print("d2");
         d1.Print("d1");
         Console.ReadLine();
      }
    }

# Deep Copy

    class Demo:ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Print(string objectName)
        {
            Console.WriteLine($"Object Name- {objectName} \nFirst Name- {FirstName} \nLast Name- {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Demo d1 = new Demo();
            d1.FirstName = "Peter";
            d1.LastName = "Parker";

            d1.Print("d1");

            Demo d2 = new Demo();
            d2 = (Demo)d1.Clone();
            d2.FirstName = "Rachel";
            d2.Print("d2");
            d1.Print("d1");

            Console.ReadLine();

        }
    }
    
    
 # Reference Copy
 
    class Demo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Print(string objectName)
        {
            Console.WriteLine($"Object Name- {objectName} \nFirst Name- {FirstName} \nLast Name- {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.FirstName = "Peter";
            d1.LastName = "Parker";
            d1.Print("d1");

            Demo d2 = new Demo();
            d2 = d1;
            d2.FirstName = "Rachel";
            d2.Print("d2");
            d1.Print("d1");

            Console.ReadLine();
        }
    }
    
    
# Func vs Action 

Func and Action are predefined generic delegates, which take zero to sixteen input parameters.
The basic difference between both is that Func always returns a value while Action doesn’t return a value.
Both Func and Action delegates must be defined before they are called, while a Local function can be defined later in the method.

     Func<int,(int,string)> example1Func = (int x) =>
     {
         Console.WriteLine("Write {0}", x);
         return (x,"");
     };

     Func<int, int,int> example2Func = (x, y) =>
     {
         Console.WriteLine("Write {0} and {1}", x, y);
         return x + y;
     };

     Func<int> example3Func = () =>
     {
         Console.WriteLine("Done");
         return 10;
     };
     
     
     // Func
     // Can take 16 input and 1 output
     Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int,int > sum = 
         delegate (int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, 
         int a11, int a12, int a13, int a14, int a15, int a16)
     {
         return a1 + a2;
     };
     int result = sum(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,167);
     Console.WriteLine(result);


     // Func
     Func<int, bool> checkPrimeNumber = x =>
     {
         bool isPrime = false;
         int i;
         for (i = 2; i <= x - 1; i++)
         {
             if (x % i == 0)
             {
                 isPrime = false;
                 break;
             }
         }
         if (i == x)
         {
             isPrime = true;
         }
         return isPrime;
     };
     
     
     
     Action<int> example1 = (int x) => 
     {
         Console.WriteLine("Write {0}", x);
     };

     Action<int, int> example2 = (x, y) => 
     {
         Console.WriteLine("Write {0} and {1}", x, y);
     };

     Action example3 = () => 
     {
         Console.WriteLine("Done");
     };

     // Call the anonymous methods.
     example1.Invoke(1);
     example2.Invoke(2, 3);
     example3.Invoke();

     // Can take 16 input
     Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Squre = 
         delegate (int a1, int a2, int a3, int a4, int a5, int a6, int a7, 
         int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16)
     {
         Console.WriteLine(a1 * a1);
     };
     
     




# Predicate    

A Predicate returns true or false
This C# type stores a method that receives 1 parameter and returns 1 value of true or false.
And it is often used with lambda expression syntax.

      //
      // This Predicate instance returns true if the argument is one.
      //
      Predicate<int> isOne =
          x => x == 1;
      //
      // This Predicate returns true if the argument is greater than 4.
      //
      Predicate<int> isGreaterEqualFive =
          (int x) => x >= 5;


      //
      // Test the Predicate instances with various parameters.
      //
      Console.WriteLine(isOne.Invoke(1));
      Console.WriteLine(isOne.Invoke(2));
      Console.WriteLine(isGreaterEqualFive.Invoke(3));
      Console.WriteLine(isGreaterEqualFive.Invoke(10));



# Local Function

The Local function is a new concept introduced in C# 7. 
The Local function can be defined in the body of any method and property’s getter and setter.
All the arguments and the local variables in the outer function are in scope of a local function.
These local functions can use ref and out parameters.

     // Local Function
     int num = 10;
     long GetFactorial(int number)
     {
         return number == 0 ? 1 : number * GetFactorial(number - 1);
     }
     long fact = GetFactorial(num);
     Console.WriteLine($"{num} factorial is {fact}");
     
     
# Abstract Class

1. We can not have abstratc method in non abstratc class
2. A abstract class can have both abstratc and non- abstract methds
3. Can not create the instance of abstratc class
4. Its mandatroy to override the abstratc method in derived class
5. Derived class can not have same name method as abstrat class
6. Abstract class can have the construtor.

         abstract class Demo
         {
             public void ShowFirstName()
             {
                 Console.WriteLine("I am James.");
             }

            abstract public void ShowLastName();
         }
         
         class Demo1:Demo
         {
             public override void ShowLastName()
             {
                 Console.WriteLine("I am Anderson.");
             }
         }

# Optional vs Named Parameters

Optional Parameters
An optional parameter has a default value. A method with an optional parameter can be called with only some of its parameters specified. Using this feature in new versions of the C# language, we add default values for formal parameters.




     using System;

     class Program
     {
         static void Main()
         {
             // Omit the optional parameters.
             Method();

             // Omit second optional parameter.
             Method(4);

             // You can't omit the first but keep the second.
             // Method("Dot");

             // Classic calling syntax.
             Method(4, "Dot");

             // Specify one named parameter.
             Method(name: "Sam");

             // Specify both named parameters.
             Method(value: 5, name: "Allen");
         }

         static void Method(int value = 1, string name = "Perl")
         {
             Console.WriteLine("value = {0}, name = {1}", value, name);
         }
     }

     Output

     value = 1, name = Perl
     value = 4, name = Perl
     value = 4, name = Dot
     value = 1, name = Sam
     value = 5, name = Allen
    
# Private Construtor

1. You can not create the object of that class which has "Private Construtor".
2. You can not inherit that class with the derive class which has "Private Construtor".  

# Virtual

     namespace TestDemo
     {
  
         public class Base
         {
             public virtual void Show()
             {
                 Console.WriteLine("Show base.");
             }
         }

         public class Base1:Base
         {
             public override void Show()
             {
                 Console.WriteLine("Show base 1.");
             }
         }

         public class Drive : Base1
         {
             public override void Show()
             {
                 Console.WriteLine("Show drive.");
             }
         }


         class Program
         {
             static void Main(string[] args)
             {

                 Base b = new Base1();
                 Base1 b1 = new Drive();


                 b.Show();  // Show Base 1
                 b1.Show(); // Show Drive
                 Console.ReadLine();
             }
         }
     }
     
 =============================================================
     
      public class Base
      {
          public virtual void Show()
          {
              Console.WriteLine("Show base.");
          }
      }

      public class Base1:Base
      {
          public new void Show()
          {
              Console.WriteLine("Show base 1.");
          }
      }

      public class Drive : Base1
      {
          public new void Show()
          {
              Console.WriteLine("Show drive.");
          }
      }
      
      class Program
      {
             static void Main(string[] args)
             {

                 Base b = new Base1();
                 Base1 b1 = new Drive();


                 b.Show();  // Show Base 1
                 b1.Show(); // Show Base
                 Console.ReadLine();
             }
      }
     


