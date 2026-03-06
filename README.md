# Geometric Figures

This project was developed in **C#** using **Visual Studio**.

It calculates the **area** and **perimeter** of different geometric figures by using **inheritance**, **abstraction**, **encapsulation**, and **polymorphism**.

## Objective

The purpose of this project is to represent several geometric figures through classes and apply the corresponding formulas to calculate their area and perimeter.

## Classes Included

The project contains the following classes:

- `GeometricFigure` (abstract class)
- `Circle`
- `Square`
- `Rectangle`
- `Rhombus`
- `Kite`
- `Parallelogram`
- `Triangle`
- `Trapeze`

## Formulas Used

### Circle
- Area = πR²
- Perimeter = 2πR

### Square
- Area = A²
- Perimeter = 4A

### Rectangle
- Area = A × B
- Perimeter = 2(A + B)

### Rhombus
- Area = (D1 × D2) / 2
- Perimeter = 4A

### Kite
- Area = (D1 × D2) / 2
- Perimeter = 2(A + B)

### Parallelogram
- Area = B × H
- Perimeter = 2(A + B)

### Triangle
- Area = (B × H) / 2
- Perimeter = A + B + C

### Trapeze
- Area = ((B + D) × H) / 2
- Perimeter = A + B + C + D

## Programming Concepts Applied

### Abstraction
`GeometricFigure` is an abstract class that defines the common structure for all geometric figures.

### Inheritance
Each figure inherits from `GeometricFigure` or from another derived class.

### Polymorphism
Each class overrides the methods `GetArea()` and `GetPerimeter()` to provide its own implementation.

### Encapsulation
The properties validate the assigned values to make sure they are greater than zero.

## How the Program Works

The main program creates one object for each geometric figure and stores them in a `List<GeometricFigure>`.  
Then, it uses a `foreach` loop to print the area and perimeter of each figure.

## Project Structure

```text
GeometricFigures
│
├── Backend
│   ├── GeometricFigure.cs
│   ├── Circle.cs
│   ├── Square.cs
│   ├── Rectangle.cs
│   ├── Rhombus.cs
│   ├── Kite.cs
│   ├── Parallelogram.cs
│   ├── Triangle.cs
│   └── Trapeze.cs
│
└── Program.cs
```
Example Output
```
Circle         => Area......:     78.53982     Perimiter:     31.41593
Square         => Area......:    100.00000     Perimiter:     40.00000
Rhombus        => Area......:     35.00000     Perimiter:     20.00000
Kite           => Area......:     15.00000     Perimiter:     30.00000
Rectangle      => Area......:    309.66472     Perimiter:    144.71600
Parallelogram  => Area......:  1,262.33030     Perimiter:    138.64000
Triangle       => Area......:     92.55000     Perimiter:     84.99000
Trapeze        => Area......:    600.00000     Perimiter:    100.00000
