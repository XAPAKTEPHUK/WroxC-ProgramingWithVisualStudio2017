# Chapter 8 - INTRODUCTION TO OBJECT-ORIENTED PROGRAMMING
## Objects and Classes
### Objects are the building blocks of OOP applications. Classes are type definitions that are used to instantiate objects. Objects can contain data and/or expose operations that other code can use. Data can be made available to external code through properties, and operations can be made available to external code through methods. Both properties and methods are referred to as class members. Properties can allow read access, write access, or both. Class members can be public (available to all code), or private (available only tocode inside the class definition). In .NET, everything is an object.
## Object Life Cycle
### An object is instantiated by calling one of its constructors. When an object is no longer needed, it is destroyed by executing its destructor. To clean up after an object, it is often necessary to manually dispose of it.
## Static and Instance Members
### Instance members are available only on object instances of a class. Static members are available only through the class definition directly, and are not associated with an instance.
## Interfaces 
### Interfaces are a collection of public properties and methods that can be implemented on a class. An instance-typed variable can be assigned a value of any object whose class definition implements that interface. Only the interface-defined members are then available through the variable.
## Inheritance
### Inheritance is the mechanism through which one class definition can derive from another. A class inherits members from its parent, of which it can have only one. Child classes cannot access private members in its parent, but it is possible to define protected members that are available only within a class or classes that derive from that class. Child classes can override members that are defined as virtual in a parent class. All classes have an inheritance chain that ends in system.Object, which has the alias object in C#.
## Polymorphism
### All objects instantiated from a derived class can be treated as if they were instances of a parent class.
## Object Relationships and Features 
### Objects can contain other objects, and can also represent collections of other objects. To manipulate objects in expressions, you often need to define how operators work with objects, through operator overloading. Objects can expose events that are triggered due to some internal process, and client code can respond to events by providing event handlers.
