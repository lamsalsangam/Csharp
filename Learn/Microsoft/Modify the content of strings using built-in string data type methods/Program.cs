﻿// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// ##############################################################################################

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

// ##############################################################################################

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the quantity
int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");
quantityStart += "<span>".Length; // Added length of the tag so index moves to end of the tag
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div>");
int divLength = "<div>".Length;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div>");
int divCloseLength = "</div>".Length;
output = output.Remove(divCloseStart, divCloseLength);
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);