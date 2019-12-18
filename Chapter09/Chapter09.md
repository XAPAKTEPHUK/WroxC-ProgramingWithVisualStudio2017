# Chapter 9 -   DEFINING CLASSES -
## Class and Interface Definitions
### Classes are defined with the class keyword, and interfaces with the interface keyword. You can use the public and internal keywords to define class and interface accessibility, and classes can be detined as abstract or sealed control inheritance. Parent classes and interfaces are specified in a comma separated list after a colon following the class or interface name. Only a parent class can be specified in a class definition, and it must be the first item in the list.
## Constructors and Destructors
### Classes come ready-equipped with a default constructor and destructor implamentation, and you rarely have to provide your own destructor. You can define constructors with an accessibility, the name of the class, and any required parameters. Constructors of base classes are executed before those of derived classes, and you can control the execution sequence within a class with this and base constructor initializer keywords.
## Class Libraries
### You can create class library projects that only contain class definitions. These projects cannot be executed directly; they must be accessed through client code in an executable application. Visual Studio provides various tools for creating, modifying, and examining classes.
## Class Families
### Classes can be grouped into families that exhibit common behavior or that share common characteristics. You can do this by inheriting from a shared base class (which can be abstract), or by implementing interfaces.
## Struct Definitions
### A struct is defined in a very similar way to a class, but remember that structs are value types whereas classes are reference types.
## Copying Objects
### When you make a copy of an object, you must be careful to copy any objects that it might contain, rather than simply copying the references to those objects. Copying references is referred to as shallow copying, whereas a full copy is referred to as a deep copy. You can use the ICloneable interface as a framework for providing deep-copy capabilities in a class definition.
