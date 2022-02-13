# Project_Pierre Bakery 

#### By Wajma Niazi

#### 

## Technologies Used

* VS Code
* C# 
* .NET 5.0


## Description
__Create a C# console application for a bakery that includes the following functionality:

__There should be two classes: one for Bread and one for Pastry.

__When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

__A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

__The application will return the total cost of the order.

__Pierre offers the following deals:

__Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
__All functionality for the models should be tested.


## Setup/Installation Requirements
 
* _Go to GitHub: https://github.com/WNiazi/Project_Bakery.git 
* _Clone Repository to your deskto
* _dotnet build 
* _dotnet run
* _dotnet test (if you would like to test)



## Testing
``` 
Describe: Creating a Object property and using it against the User's inputs.  
```
Test: It will bring in UserInput 
Code: 
        Console.WriteLine("How many pastries would you like? [1 - 10]");
        string stringTempP = Console.ReadLine(1);
        int inputtedPastriesAmount = 0;
        Int32.TryParse(stringTempP, out inputtedPastriesAmount);
Expected Output: 1  
```
Test: It will calculate the total bread/pastry.   
Code: For Bread= Amount * 5 ; For Pastry=Amount *2; 
Expected Output:  (5,2) 
```
Test: It will provide total. 
Code: Bread + Pastry =7; 
Expected Output: 7 
```

## Known Bugs
*_ None 

## License

_MIT

Copyright (c) 2021 Wajma Niazi