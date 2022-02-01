# Design Patterns using C# and .NET 6
The design patterns are implemented for my own learning purposes.

**_What?_**
> Design patterns are reusable design level solutions for recurring software problems.
> They are guidelines, a blueprint about how one should approach a specific challenge.

**_Why?_**
> - Robustness→ They are battle tested and proven paradigm.
> - Enhances Software Development→ Better understanding of design patterns and when to use which pattern, speeds up the development process.
> - Simplifying Software Development→ They take the reponsibility away from the developer (Creational patterns→ takes the repsonsibility of object creation), so that, developers can focus on achieving their end result.

**_When?_**
> Assume you're working on something, first try and get a simple solution together.
> Now review it and try to find out, if it is attempting to solve an underlying problem to which a design pattern can be applied.

# Technology Stack
- C# with .NET 6.0
- xUnit

# Classification
1. Creational Patterns
    1. Simple Factory Pattern
    2. Factory Method Pattern
    3. Abstract Factory Pattern
    4. Singleton Pattern
    5. Builder Pattern
    6. Prototype Pattern
2. Structural Patterns
    1. Adapter Pattern
    2. Bridge Pattern
    3. Composite Pattern
    4. Decorator Pattern
    5. Facade Pattern
    6. Flyweight Pattern
    7. Proxy Pattern
3. Behavioural Patterns
    1. Chain of Responsibility Pattern
    2. Command Pattern
    3. Interpreter Pattern
    4. Iterator Pattern
    5. Mediator Pattern
    6. Memento Pattern
    7. Observer Pattern
    8. State Pattern
    9. Startegy Pattern
    10. Template Method Pattern
    11. Visitor Pattern
***
## Creational Pattern
**_What?_**
> The design patterns that deal with the object creation mechanism are called Creational design-patterns/Creational patterns.<br>
> They aim to separate a system from how its objects are created, composed, and represented.<br>
> They have 2 dominant ideas:
> - Encapsulating the knowledge about which concrete classes system uses.
> - Hiding how instances of these concrete classes are created and combined.

**_Why?_**
> The basic form of object creations, using the new keyword for example→ `var objectOfSomeType = new SomeType();`, could result in design problems or added complexity in design.
> Creational patterns solve this problem by controlling this object creations in one way or other.

**_When?_**
> A system should be independent of how its objects and products are created.<br>
> There must be a single instace and client can access this instance at all times.<br>
> Hiding the implementations of a class library, revealing only their interfaces. The class instantiations are specified at run-time.

### 1.1 Simple Factory Pattern
**_What?_**
> A factory class with a method that returns different implementations wrapped in a same base type, based on the input provided.<br>
> For example→ `EngineFactory.cs`([link](https://github.com/phougatv/vp-design-patterns/blob/master/src/Creational/1_SimpleFactory/Factories/EngineFactory.cs)), it moves the object creation mechanism to one centralized class otherwise known as factory and thus removes the need to use the `new` keyword from the client classes.
> In future if you want the factory to return another type that inherits/implements the same base type, you have to add one more else if clause or case statement in the factory class without disturbing existing code at any other client location.

**_When?_**
> When one needs different objects based on different inputs.<br>

### 1.2 Factory Method Pattern
**_What?_**

**_When_**

### 1.3 Abstract Factory Pattern
### 1.4 Singleton Pattern
### 1.5 Builder Pattern
### 1.6 Prototype Pattern
***
## Structural Patterns
### 2.1 Adapter Pattern
### 2.2 Bridge Pattern
### 2.3 Composite Pattern
### 2.4 Decorator Pattern
### 2.5 Facade Pattern
### 2.6 Flyweight Pattern
### 2.7 Proxy Pattern
***
## Behavioural Patterns
### 3.1 Chain of Responsibility Pattern
### 3.2 Command Pattern
### 3.3 Interpreter Pattern
### 3.4 Iterator Pattern
### 3.5 Mediator Pattern
### 3.6 Memento Pattern
### 3.7 Observer Pattern
### 3.8 State Pattern
### 3.9 Startegy Pattern
### 3.10 Template Method Pattern
### 3.11 Visitor Pattern
***
# References
***
