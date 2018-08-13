# Game
When you start the game, it generates a random passcode.
Passcode contains 4 unique integer numbers from the range of 1 to 6 included.
The player tries to guess the code by giving the game an input of comma divided numbers.
The game ends if the player guesses the passcode correctly.

## Input validation
The input as well as generated passcode should go through the following validation:
1. The array should have exactly four items.
2. The items in the array should be unique.
3. None of the items should be greater than 6 or less than 4.

## Input processing
After the input is validated, the game should compare it to the randomly generated passcode.
The result of the comparison should contain:
* Numbers Placed Correctly - amount of numbers that are present both in the player's attempt and in the generated passcode on the exact same positions in the array.
* Numbers Guessed Correctly - amount of numbers that are present both in the player's attempt and in the generated passcode, but on the different positions in the array.
Please, note that number that is placed correctly is not considered as guessed correctly.
When all numbers are placed correctly, the player wins.

## Example:
```
//Generated passcode: 6,3,1,4
>> Input: 3,5,6,4
Numbers Placed Correctly: 1
//Number 4 in the input is at the same position as in the passcode
Numbers Guessed Correctly: 2
//Numbers 3 and 6 from the input are present in the passcode, but in the wrong positions
```

# Task
The candidate should build a fully functional game based on the given skeleton.

## Skeleton
1. `mastermind\Program.cs` (fully implemented)
  * Creates Game
  * Reads input handling 'exit' keyword
  * Parses input into an array of numbers
  * Passes parsed input into `Game.Guess()` method.
  * Outputs the attempt result.
  * Handles win condition.
2. `mastermind.core\RandomCodeGenerator.cs` to be implemented;
3. `mastermind.core\Game.cs` to be implemented;
4. `mastermind.test\GameTest.cs` as a test class template;

## Expectations
1. `RandomCodeGenerator.Generate()` generates valid passcode according to game rules.
2. `Game.Guess()` validates input.
3. `Game.Guess()` returns object of a type `AttemptResult`, with properties `NumbersPlacedCorrectly` and `NumbersGuessedCorrectly` set according to game rules.
4. All code outside `Program.cs` or `AttemptResult.cs` must be covered with Unit Tests.
