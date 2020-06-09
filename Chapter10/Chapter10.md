# Chapter 10: Defining Class Members

## Member Definitions
### You can defind field, method, and property members ina class. Fields are defined with an accesibility, name and type. Methods are defined with an accessibility, return type, name and parameters. Properties are defined with accesibility, name and get and/or set accesor. Individual property accessors can have their own accesibility, which must be less accessible then the property as a whole. 

## Member Hiding and Overrides
### Properties and methods can be defined as abstract or virtual in base classes to define inheritance. Derived classes must implement abstract members, and can override virtual members, with the override keword. They can also provide new implementations with the new keyword, and prevent further overrides for virtual members with the sealed keyword. Base implementations can be called with the base keyword.

## Interface Implementations
### A class that implemnts an inteface must implement all of the members defined by the interface as public. You can implement interfaces implicitly or explicitly, where explicit implementations are only available throught interface reference.

## Partial Definitions
### You can split class definitions accross multiple code files with the partial keyword. You can also create partial methods with partial keyword. Partial methods have certain restrictions, including no return value or out parameters, and are not compiled if no implementation is provided.  
