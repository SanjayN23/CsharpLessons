﻿using LibraryA;
Book book = new LibraryA.Book();
book.Title = "To kill a mocking Bird";
book.Author = "Harper lee";
book.Genre = "Social";
book.BookPrice = 250;
book.Dateofpublish = new DateTime(1195, 06, 01);
book.BookmarkedPage(125);
Console.WriteLine(book.GetCurrentPage());
Calculator calculator = new Calculator();
int addResult = calculator.Add(100, 40);
Console.WriteLine(addResult);
int multiplyResult = calculator.Multiply(100, 40);
Console.WriteLine(multiplyResult);
int divideResult = calculator.Divide(100, 40);
Console.WriteLine(divideResult);
