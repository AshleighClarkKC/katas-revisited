# Kaleidocode: Katas

### Kata 1: String Calculator (Part 1)

#### Requirements
- Create a simple String calculator with a method int ```Add(string numbers)```.
  - The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0), for example, ```“”``` or ```“1”``` or ```“1,2”```.
  - Start with the simplest test case of an empty string and move to 1 and two numbers.
  - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about.
  - Remember to refactor after each passing test.
- Allow the Add method to handle an unknown amount of numbers.
- Allow the Add method to handle new lines between numbers (instead of commas).
  - the following input is ok: ```“1\n2,3”``` (will equal 6).
  - the following input is NOT ok: ```“1,\n”``` (no need to prove it - just clarifying).
- Support custom delimiters.
  - to change a delimiter, the beginning of the string will contain a separate line that looks like this: ```“//[delimiter]\n[numbers…]”``` for example ```“//;\n1;2”``` should return 3 where the default delimiter is ‘;’.
  - the first line is optional - all existing scenarios should still be supported (i.e. default delimiters).
- Calling Add with a negative number will throw an exception with the message “Negatives not allowed: \{negative numbers\}” where “\{negative numbers\}” is the negative numbers that were found in the string. If more than one negative is found in the input, show them all in the exception message.
- Numbers bigger than 1000 should be ignored, so adding 2 + 1001  = 2.
- Allow multiple custom delimiters like this:  ```“//[delim1][delim2]\n”``` for example ```“//[*][%]\n1*2%3”``` should return 6. Note that the square brackets seen here are only required for multiple custom delimiters. A single custom delimiter (requirement 7) does not need the square brackets.
- Make sure you can also handle multiple custom delimiters with lengths longer than one character.

<br />
<hr />
<br />

### Kata 2: String Calculator (Part 2)

#### Requirements
- Create a simple String calculator with a method ```int Subtract(string numbers)```
  - The method can take 0, 1 or 2 numbers, and will return their negative sum (for an empty string it will return 0). For example ```“”``` or ```“1”``` or ```“1,2”``` should return ```0, -1``` and ```-3``` respectively.
  - Start with the simplest test case of an empty string and move to 1 and 2 numbers.
  - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about.
  - Remember to refactor after each passing test.
- Allow the Subtract method to handle an unknown amount of numbers.
- Allow the Subtract method to handle new lines between numbers (instead of commas).
  - the following input is ok: ```1\n2,3``` (will equal -6).
  - the following input is NOT ok: ```1,\n``` (no need to prove it - just clarifying).
- Support custom delimiters:
  - to change a delimiter, the beginning of the string will contain a separate line that looks like this:   
  ```##[delimiter]\n[numbers…]```. For example ```##[;]\n1;2``` should return -3, where the default delimiter is ```‘;’```.
  > The first line is optional - all existing scenarios should still be supported.
- Calling Subtract with a negative number is presumed to be an error, and should be corrected by you. Assume negative numbers are positive, e.g 10,-2 should return -12 (not -8).
- Numbers bigger than 1000 should throw an exception with the message ```“Numbers over 1000 not allowed: {numbers}”``` where ```{numbers}``` are the numbers over 1000 found in the input. If multiple numbers are bigger than 1000, return all of them in the message.
- Allow custom delimiters of any length with the following format: ```##[delimiter]\n``` for example: ```##[***]\n1***2***3``` should return -6.
- Allow multiple custom delimiters like this:  ```##[delim1][delim2]\n``` for example ```##[*][%]\n1*2%3``` should return -6.
- Make sure you can also handle multiple custom delimiters with lengths longer than one character.
- Allow letters to be used in place of numbers 0 through 9:
  - ‘a’ has value 0, ‘b’ is 1, ‘c’ is 2 etc. until 'j’, which is 9
  - If ‘k’ or any subsequent letters are provided, silently ignore them and continue calculating the sum of any remaining valid input.
  > e.g: ```“a,b”``` should equal -1; ```“b,c”``` should equal -3; ```“i,j,k”``` should equal -17.
  - Note that any combination of letters and numbers should be allowed i.e. ```“b,2”``` should equal -3.
- Allow the customization of the delimiter separators by supplying a delimiter-character start flag “<” and end flag “>”, just before the character, and at the beginning of the string. For example:
  - ```<(>)##(*)\n1*2*3``` should return -6.
    - ```<(``` denotes that that start of the delimiter is ```(```.
    - ```>)``` denotes that the end of the delimiter is ```)```.
    - ```##``` denotes the start of a custom delimiter as per requirement **4**.
  - ```<{>}##{%}\n2%3%4``` should return -9.
  - ```<[>}##[::}\n3::4::5``` should return -12.
  - ```<>><##>&<\n4&5&6``` should return -15.
- Ensure requirement 11 is compatible with requirements 8 and 9, allowing multiple custom delimiters with a delimiter length greater than 1.
  > For example: ```<<>>##<$$$><###>\n5$$$6###7``` should return -18.

<br />
<hr />
<br />

### Kata 3: String Calculator (Combine 1 & 2)

Your task is to combine the requirements of String Calculator 1 and 2 into a single application with a single entry point (i.e. a single entry method, it should not Add and Subtract as separate methods). All requirements from both katas should be present in the application. How you switch between the two feature sets is up to you.

#### Requirements: Addition

- Create simple addition calculation logic with a string input:
  - The string can have 0, 1 or 2 numbers, and will result in the sum of those numbers (for an empty string it will return 0). For example, “” or “1” or “1,2” should return 0, 1 and 3 respectively.
  - Start with the simplest test case of an empty string and move to 1 and two numbers.
  - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about.
  - Remember to refactor after each passing test.
- Allow the logic to handle an unknown amount of numbers.
- Allow the logic to handle new lines between numbers (instead of commas)
  - the following input is ok:  ```“1\n2,3”```  (will equal 6).
  - the following input is NOT ok:  ```“1,\n”``` (no need to prove it - just clarifying).
- Support custom delimiters:
  - to change a delimiter, the beginning of the string will contain a separate line that looks like this: ```“//[delimiter]\n[numbers…]”``` for example ```“//;\n1;2”``` should return 3 where the default delimiter is ```‘;’```.
  > The first line is optional - all existing scenarios should still be supported (i.e. default delimiters).
- Calling the logic with a negative number will throw an exception with the message ```“Negatives not allowed: {negative numbers}”``` where ```{negative numbers}``` are the negative numbers that were found in the string. If more than one negative is found in the input, show them all in the exception message.
- Numbers bigger than 1000 should be ignored, so adding 2 + 1001 = 2.
- Support custom delimiters of any length with the following format: ```“//[delimiter]\n”``` for example: ```“//***\n1***2***3”``` should return 6.
- Allow multiple custom delimiters like this:  ```“//[delim1][delim2]\n”``` for example ```“//[*][%]\n1*2%3”``` should return 6.
- Make sure you can also handle multiple custom delimiters with lengths longer than one character.

#### Requirements: Subtraction

- Create simple subtraction calculation logic with a string input:
  - The string can have 0, 1 or 2 numbers, and will result in the negative sum of those numbers (for an empty string it will return 0). For example, ```“”``` or ```“1”``` or ```“1,2”``` should return 0, -1 and -3 respectively.
  - Start with the simplest test case of an empty string and move to 1 and 2 numbers.
  - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about.
  - Remember to refactor after each passing test.
- Allow the logic to handle an unknown amount of numbers.
- Allow the logic to handle new lines between numbers (instead of commas).
  - the following input is ok:  ```“1\n2,3”``` (will equal -6)
  - the following input is NOT ok: ```“1,\n”``` (no need to prove it - just clarifying).
- Support custom delimiters:
  - to change a delimiter, the beginning of the string will contain a separate line that looks like this: 
    - ```“##[delimiter]\n[numbers…]”```. For example ```“##[;]\n1;2”``` should return -3, where the default delimiter is ```‘;’```.
    > The first line is optional - all existing scenarios should still be supported.
- Calling the logic with a negative number is presumed to be an error, and should be corrected by you. Assume negative numbers are positive, e.g 10,-2 should return -12 (not -8).
- Numbers bigger than 1000 should throw an exception with the message ```“Numbers over 1000 not allowed: {numbers}”``` where ```{numbers}``` are the numbers over 1000 found in the input. If multiple numbers are bigger than 1000, return all of them in the message.
- Allow custom delimiters of any length with the following format: ```“##[delimiter]\n”``` for example: ```“##[***]\n1***2***3”``` should return -6.
- Allow multiple custom delimiters like this:  ```“##[delim1][delim2]\n”``` for example ```“##[*][%]\n1*2%3”``` should return -6.
- Make sure you can also handle multiple custom delimiters with lengths longer than one character.
- Allow letters to be used in place of numbers 0 through 9:
  - ‘a’ has value 0, ‘b’ is 1, ‘c’ is 2 etc. until 'j’, which is 9.
  - If ‘k’ or any subsequent letters are provided, silently ignore them and continue calculating the sum of any remaining valid input.
  > e.g: “a,b” should equal -1; “b,c” should equal -3; “i,j,k” should equal -17
  - Note that any combination of letters and numbers should be allowed, i.e. “b,2” should equal -3.
- Allow the customization of the delimiter separators by supplying a delimiter-character start flag “<” and end flag “>”, just before the character, and at the beginning of the string. For example:
  - ```<(>)##(*)\n1*2*3``` should return -6.
    - ```<(``` denotes that that start of the delimiter is ```(```.
    - ```>)``` denotes that the end of the delimiter is ```)```.
    - ```##``` denotes the start of a custom delimiter as per **4**.
  - ```<{>}##{%}\n2%3%4``` should return -9.
  - ```<[>}##[::}\n3::4::5``` should return -12.
  - ```<>><##>&<\n4&5&6``` should return -15.
- Ensure requirement 11 is compatible with requirements 8 and 9, allowing multiple custom delimiters with a delimiter length greater than 1.
  > For example: ```<<>>##<$$$><###>\n5$$$6###7``` should return -18.

<br />
<hr />
<br />

### Kata 4: Container Loading

A seaport container terminal stores large containers that are eventually loaded on seagoing ships for transport abroad. Containers coming to the terminal by road and rail are stacked at the terminal as they arrive.

Seagoing ships carry large numbers of containers. The time to load a ship depends in part on the locations of its containers. The loading time increases when the containers are not on the top of the stacks, but can be fetched only after removing other containers that are on top of them. The container terminal needs a plan for stacking containers to decrease loading time. The plan must allow each ship to be loaded by accessing only the topmost containers on the stacks, and minimizing the total number of stacks needed. For this problem, we know the order in which ships must be loaded and the order in which containers arrive. Each ship is represented by a capital letter between A and Z (inclusive), and the ships will be loaded in alphabetical order. Each container is labelled with a capital letter representing the ship it needs to be loaded onto. There is no limit on the number of containers placed in a single stack.

#### Input

Your input should consist of a single line containing capital letters representing the order of arrival of a set of containers. For example, the line ABAC means consecutive containers arrive to be loaded onto ships A, B, A, and C, respectively. When all containers have arrived, the ships are loaded in strictly increasing order: first ship A, then ship B, and so on.

#### Output

Your code should output the minimum number of stacks needed to store the containers before loading starts.

#### Example
```
Input: A - should result in 1
Input: CBACBACBACBACBA - should result in 3
Input: CCCCBBBBAAAA - should result in 1
Input: ACMICPC - should result in 4
```