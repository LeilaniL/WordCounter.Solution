# Word Counter
#### by Leilani Leach

## Description
This program asks users for a sentence, and a word they want to find in that sentence. It counts the occurences of that word and returns the number of times it appears in the sentence. This is the first C# independent project for Epicodus.

## Setup Instructions
* Clone or download this repo
* Install .NET Core 2.1.3 SDK
* Open the console and navigate to WordCounter.Solution/WordCounter
* In the console, enter _dotnet restore_ and then _dotnet build_
* In the console, enter _dotnet run_ to start the server
* Open a browser window at _localhost:5000_
* Follow the prompts to enter a sentence and search word
* To run the tests, navigate to WordCounter.Solution/WordCounter.Tests
* Then, in the console, enter _dotnet restore_ and then _dotnet test_

## Specs
* User inputs both a sentence or paragraph, and a word that they want to count in the sentence/paragraph.
_Example: Input "the" and "The cat walks down the street."_
_Expected output: The input word plus the input sentence as an array of words ("The", "cat", "walks", "down", "the", "street")_
_This ensures the user input is being processed correctly and turned into an array._

* Program finds whether that word is in the sentence. It returns full and exact matches only.
_Example: Input "the" and "The cat walks down the street with them."_
_Expected output: true_
_This checks whether the program is correctly comparing the array word-by-word to the search query word._

* Program counts how many times that word appears in the sentence. It returns full and exact matches only.
_Example: Input "the" and "The cat walks down the street with them."_
_Expected output: 2_
_This counts the two occurences of the search query word, but not the word "them" that contains the same string._

* If there are no full, exact matches, the program returns "That word is not in the given text!"
_Example: Input "dog" and "The cat walks down the street with them."_
_Expected output: "That word is not in the given text!"_
_This tests what the program will do when there's no word matching the query word._

* Program ignores differences in uppercase/lowercase.
_Example: Input "love" and "I just love love LOVE pizza."_
_Expected output: 3_
_This ensures the program is comparing words after changing them to the same case, correctly counting all instances of the word instead of just ones with the same capitalization._

## Known Bugs
* The program won't count words next to punctuation or special characters, like a period at the end of a sentence


## Technologies Used
* C#
* .NET version 1.1.4
* MSTest framework for unit tests
* ASP.NET Core
* Razor

## Contact Info

Please email me at leilanileach@yahoo.com with any questions.

#### Copyright(c) 2018 by Leilani Leach 