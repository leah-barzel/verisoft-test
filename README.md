# Object-Oriented Assignment

## Description
This project implements an object-oriented model for animals including `Dog`, `Cat`, and `Frog` classes based on the provided analysis. The classes are structured to represent different animal behaviors and characteristics.

### Classes and Interfaces
- **Animal** (Abstract Class):
  - Attributes:
    - Mammals (boolean)
    - Carnivorous (boolean)
    - Mood (int)
  - Methods:
    - `SayHello()`
    - `SayHello(int mood)`
    - `IsMammals()`
    - `IsCarnivorous()`
  - Interfaces Implemented:
    - `ILand`
    - `IWater`

- **Dog** (Subclass of Animal):
  - Attributes:
    - Number of Legs
  - Methods:
    - `SayHello()`
    - `SayHello(int mood)`
  - Interface Implemented:
    - `ILand`

- **Cat** (Subclass of Animal):
  - Attributes:
    - Number of Legs
  - Methods:
    - `SayHello()`
    - `SayHello(int mood)`
  - Interface Implemented:
    - `ILand`

- **Frog** (Subclass of Animal):
  - Attributes:
    - Number of Legs
  - Methods:
    - `SayHello(int mood)`
  - Interface Implemented:
    - `ILand`
    - `IWater`

- **ILand** (Interface):
  - Methods:
    - `GetNumberOfLegs()`
    - `IsMammals()`

- **IWater** (Interface):
  - Methods:
    - `HasGills()`
    - `HasLaysEggs()`

### Main Program
The `Main` method creates instances of `Dog`, `Cat`, and `Frog`, displays their attributes and behaviors, and checks if they implement the `IWater` interface.
