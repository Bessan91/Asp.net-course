# 🚀 First_Project – OOP Demo in ASP.NET (C#)

This is a console-based application designed to **demonstrate Object-Oriented Programming (OOP)** using C#.

---

## 🧱 Structure

- **Person** – Base class for all people (students & teachers)
- **Student** – Inherits from `Person`, enrolls in courses
- **Teacher** – Inherits from `Person`, can be assigned courses
- **Course** – Has a name and an optional assigned teacher
- **School** – Manages students, teachers, and courses

---

## 🎯 Key Features

- 🔁 Inheritance: `Student` and `Teacher` extend from `Person`
- 📦 Encapsulation: Private fields and public methods
- 📚 Composition: `Student` and `Teacher` contain `Course` objects
- 🖨️ Display detailed info with `DisplayDetails()` methods
