# Sedan Constructor Demo (C#)

## 📌 Project Description

This is a simple **C# Console Application** created to demonstrate the concept of **Constructors and ****Destructor**s in Object-Oriented Programming (OOP).

The program allows the user to create a `Sedan` object using different constructors and display the car information.

## 🎯 Learning Objectives

This project was created to practice:

* Constructor Overloading
* Default Constructor
* Custom Constructors
* Destructor
* Properties
* Basic User Input Handling
* Object Creation in C#

## 🧩 How the Program Works

1. The user enters:

   * Car **Brand**
   * Car **Color**

2. The user selects which constructor to use:

* `1` → Constructor with **Brand only**
* `2` → Constructor with **Brand and Color**
* `Other` → **Default Constructor**

3. The program creates a `Sedan` object using the selected constructor.

4. The program then prints the **Brand and Color** of the car.

## 🏗 Class Structure

### `Sedan` Class

Fields:

* `_brand`
* `_color`

Properties:

* `Brand`
* `Color`

Constructors:

* `Sedan()` → Default constructor
* `Sedan(string brand)` → Constructor with brand only
* `Sedan(string brand, string color)` → Constructor with brand and color

Destructor:

* `~Sedan()`

The destructor is included only for **learning purposes** to demonstrate the object lifecycle in C#.

## 💻 Technologies Used

* C#
* .NET Console Application
* Visual Studio

## ▶ Example Output

```
**********Sedan Category**********
Brand is: Toyota
Color is: Red
Constructor Type:
1 => Brand only
2 => Brand + Color
Other number => Default constructor
Choose(1 or 2)?2
Custom Constructor2
Sedan Brand: Toyota
Sedan Color: Red
**************************

Repeat('y'|'n')?
```

## 📚 Educational Purpose

This project is part of learning **Object-Oriented Programming in C#**, focusing specifically on:

* Constructor behavior
* Object initialization
* Destructor concept

## 👩‍💻 Author
H.Ahmed
Created for practice while learning **C# OOP fundamentals**.
