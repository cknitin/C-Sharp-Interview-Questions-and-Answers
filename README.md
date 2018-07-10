# Encapsulation
Encapsulation is concept of binding or grouping the data member and member functions in to a single unit.

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
“Sort()” method is used with “Reverse()” to sort the array in descending order.

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

