# Lab02: Principles of Programming. SOLID

[Views original pdf file](./Lab02.pdf)

# Test
[![Test](https://github.com/teri-schools/vkich7Economy/actions/workflows/dotnet-desktop.yml/badge.svg?branch=main)](https://github.com/teri-schools/vkich7Economy/actions/workflows/dotnet-desktop.yml)


## Objectives
1. Learn to adhere to the SOLID principles and justify their application.
2. Learn to describe the program design using UML diagrams.

## Tasks
### Task 0: Preparation
1. Install .NET CLI version 6 or 7.
2. Create a separate repository on GitHub or GitLab for all your completed tasks in the "Software Engineering" course. Each task will be in a separate directory (lab-1, lab-2, ..., lab-n).
3. Grant access to the instructor (vkich7).
4. Clone the created repository.
5. Create the "lab-2" directory.
6. Go to the created directory and run the `dotnet new console` command.
7. Move to Task 1.

### Task 1: Implement the tasks following the SOLID principles.
1. Implement the `Money` class (an object of this class operates with a single currency) for working with money. The class should have:
   - A field for storing the whole part of the money (dollars, euros, hryvnias, etc.)
   - A field for storing the cents (cents, euro cents, kopecks, etc.)
   - Implement methods for displaying the amount on the screen and setting the values of the parts.
2. Create a `Product` class for working with a product or item. Implement a method that allows you to reduce the price by a given number.
3. Implement a `Warehouse` class that describes the goods stored in the warehouse: name, unit of measurement, unit price, quantity, last delivery date, etc.
4. Implement a `Reporting` class for working with reporting. Registration of product receipt (formation of an income invoice) and shipment (expense invoice). Inventory report (warehouse balances).
5. Implement the necessary methods and fields for each of the classes. For the classes, provide the implementation of constructors and methods for setting and reading values.
6. You can also add your own functionality to illustrate the SOLID principles. Examples of additional functionality:
   - Product categories
   - Specific child currency classes
   - Shopping cart

### Task 2: Write code to test the implemented functionality.

### Task 3: Describe the adherence to the SOLID principles in your code.
1. Add comments to the corresponding lines of code to explain and justify each of the five SOLID principles.
2. The comments can be left in Ukrainian or (preferably) English.

### Task 4: UML diagram
1. Prepare a diagram of the created classes and interfaces using https://app.diagrams.net/.
2. Export the created diagram and push the exported file to the root directory of the project.