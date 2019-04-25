# Scrabble Scorer

#### A program that takes a word and returns the Scrabble score for that word

#### By **Tessa Sullivan and **

## Description

When the user enters a word, the program will return the score for that word based on the following values:
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| Welcome message displayed| User starts the program | Output: Welcome message and prompt to enter word|
| User enters nothing|Input: enter|Output: User prompted to enter a word|
| User enters string with non-alphabet character| Input: 5| Output: Error message and user prompted to enter a word|
| User enters string with non-alphabet character| Input: A5| Output: Error message and user prompted to enter a word|
| User enters string with special character| Input: '| Output: Error message and user prompted to enter a word|
| User enters single letter word| Input: A| Output: 1|
| User enters word which contains some of the above letters| Input: the | Output: 6|
| User enters word which contains some of the above letters| Input: quick | Output: 21|
| User enters word which contains some of the above letters| Input: brown | Output: 10|
| User enters word which contains some of the above letters| Input: fox | Output: 13|
| User enters word which contains some of the above letters| Input: jumps | Output: |
| User enters word which contains some of the above letters| Input: over | Output: |
| User enters word which contains some of the above letters| Input: lazy | Output: |
| User enters word which contains some of the above letters| Input: dog | Output: |
| User enters word which is longer than the limit 16| Input: supercalifragistic | Output: Error message and user prompted to enter a new word|




## Setup/Installation Requirements

Currently does not include Program.cs so it cannot be run directly from the command line.  Tests can be run by doing the following:
1. Install .Net 2.2 
    * Go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and download the appropriate installer for your OS.
2. cd to repo directory
3. On the command line, run:
    * dotnet test LeetSpeak.Tests

## Known Issues
* No known issues at this time

## Technologies Used

* C#

## Support and contact details

_Contact Tessa Sullivan @ tessa.sullivan@gmail.com_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_Tessa Sullivan and Kevin Garvey_**