# Chapter 6 - FUNCTIONS
## Defining Functions
### Functions are defined with a name, zero or more parameters, and a return type. The name and parameters of a function collectively define the signature of the function. It is possible to define multiple functions whose signature sent even though their names are the same-this is called function overloading. Functions can also be defined within struct types.
## Return Values and Parameters 
### The return type of a function can be any type, or void if the function does ot return a value. Parameters can also be of any type, and consist of a comma-separated list of type and name pairs. A variable number of parameters of a specified type can be specified through a parameter array. Parameters can be specified as ref or out parameters in order to return values to the caller. When calling a function, any arquments specified must match the parameters in the definition both in type and in order and must include matching ref and out keywords if these are used in the parameter definition.
## Variable Scope
### Variables are scoped according to the block of code where they are defined. Blocks of code include methods as well as other structures, such as the body of a loop. It is possible to define multiple, separate variables with the same name at different scope levels.
## Command-line Parameters
### The Main () function in a console application can receive command-line parameters that are passed to the application when it is executed. When executing the application, these parameters are specified by arguments separated by spaces, and longer arguments can be passed in quotes.
## Delegates
### As well as calling functions directly, it is possible to call them through delegates. Delegates are variables that are defined with a return type and parameter list. A given delegate type can match any method whose return type and parameters match the delegate definition.
