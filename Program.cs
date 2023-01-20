// using System;
// using System.Collections.Generic;

int maxRounds = 0;
int roundCounter = 0;
int winningNumberTwo = 0;
int winningNumberThree = 0;
int playerOneScore = 0;
int playerTwoScore = 0;
string playerOneInput;
string playerTwoInput;
int validNum = 0;
int validNumTwo = 0;
string playerModeInput;
string gameModeInput;
string[] inputArr = { "rock", "paper", "scissors", "lizard", "spock" };
Random r = new Random();
int cpuInput = r.Next(1, inputArr.Length + 1);
bool run = true;

while (run)
{
    bool checkNum = false;
    while (!checkNum)
    {
        Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK");
        Console.WriteLine("Select Player Mode:\n1. Player1 vs Player2\n2. Player1 vs CPU");
        playerModeInput = Console.ReadLine();
        validNum = 0;
        checkNum = Int32.TryParse(playerModeInput, out validNum);
        if (!checkNum)
        {
            Console.WriteLine("Please enter 1 or 2 to make a selection.");
        }
        else if (validNum > 2 || validNum < 1)
        {
            Console.WriteLine("Please enter 1 or 2 to make a selection");
            checkNum = false;
        }
    }

    bool checkNumTwo = false;
    while (!checkNumTwo)
    {
        Console.WriteLine("Select Game Mode:\n1. Best 1 out of 1\n2. Best 3 out of 5\n3. Best 4 out of 7");
        gameModeInput = Console.ReadLine();
        validNumTwo = 0;
        checkNumTwo = Int32.TryParse(gameModeInput, out validNumTwo);
        if (!checkNumTwo)
        {
            Console.WriteLine("Please enter 1, 2, or 3");
        }
        else if (validNumTwo > 3 || validNumTwo < 1)
        {
            Console.WriteLine("Please enter 1, 2, or 3");
            checkNumTwo = false;
        }
    }

    switch (validNumTwo)
    {
        case 1:
            maxRounds = 1;
            break;
        case 2:
            maxRounds = 5;
            winningNumberTwo = 3;
            break;
        case 3:
            maxRounds = 7;
            winningNumberThree = 4;
            break;
        default:
            break;
    }

    if((validNum == 1 && validNumTwo == 1) || (validNum == 1 && validNumTwo == 2) || (validNum == 1 && validNumTwo == 3))
    {
        while(roundCounter < maxRounds)
        {
              if(validNumTwo == 1)
            {
                Console.WriteLine("Game Mode: Best 1 out of 1");
            }
            else if(validNumTwo == 2)
            {
                Console.WriteLine("Game Mode: Best 3 out of 5");
            }
            else if(validNumTwo == 3)
            {
                Console.WriteLine("Game Mode: Best 4 out 7");
            }
            Console.WriteLine("Player 1 make your choice: Rock, Paper, Scissors, Lizard, Spock");
            playerOneInput = Console.ReadLine().ToLower();
            while(!inputArr.Contains(playerOneInput))
            {
                Console.WriteLine("Inavlid Entry");
                playerOneInput = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Player 2 make your choice: Rock, Paper, Scissors, Lizard, Spock");
            playerTwoInput = Console.ReadLine().ToLower();
            while(!inputArr.Contains(playerTwoInput))
            {
                Console.WriteLine("Inavlid Entry");
                playerTwoInput = Console.ReadLine().ToLower();
            }
            if(playerOneInput == playerTwoInput)
            {
                Console.WriteLine("Tie!");
            }
            else if ((playerOneInput == "rock" && (playerTwoInput == "scissors" || playerTwoInput == "lizard")) || (playerOneInput == "paper" && (playerTwoInput == "rock" || playerTwoInput == "spock")) || (playerOneInput == "scissors" && (playerTwoInput == "lizard" || playerTwoInput == "paper")) || (playerOneInput == "lizard" && (playerTwoInput == "paper" || playerTwoInput == "spock")) || playerOneInput == "spock" && (playerTwoInput == "rock" || playerTwoInput == "scissors"))
            {
                Console.WriteLine($"Player 1 wins round {roundCounter + 1}!");
                playerOneScore++;
                Console.WriteLine($"P1 Score: {playerOneScore}");
                if(playerOneScore == winningNumberTwo || playerOneScore == winningNumberThree)
                {
                    Console.WriteLine("Player 1 wins!");
                    roundCounter = maxRounds;
                }
            }
            else
            {
                Console.WriteLine($"Player 2 wins round {roundCounter + 1}!");
                playerTwoScore++;
                Console.WriteLine($"P2 Score: {playerTwoScore}");
                if(playerTwoScore == winningNumberTwo || playerTwoScore == winningNumberThree)
                {
                    Console.WriteLine($"Player 2 wins!");
                    roundCounter = maxRounds;
                }
            }
            roundCounter++;
        }
    }
    else if((validNum == 2 && validNumTwo == 1) || (validNum == 2 && validNumTwo == 2) || (validNum == 2 && validNumTwo == 3))
    {
        while(roundCounter < maxRounds)
        {
            if(validNumTwo == 1)
            {
                Console.WriteLine("Game Mode: Best 1 out of 1");
            }
            else if(validNumTwo == 2)
            {
                Console.WriteLine("Game Mode: Best 3 out of 5");
            }
            else if(validNumTwo == 3)
            {
                Console.WriteLine("Game Mode: Best 4 out 7");
            }
            Console.WriteLine("Player 1 make your choice: Rock, Paper, Scissors, Lizard, Spock");
            playerOneInput = Console.ReadLine().ToLower();
            while(!inputArr.Contains(playerOneInput))
            {
                Console.WriteLine("Inavlid Entry");
                playerOneInput = Console.ReadLine().ToLower();
            }
            if(playerOneInput == inputArr[cpuInput])
            {
                Console.WriteLine("Tie!");
            }
            else if ((playerOneInput == "rock" && (inputArr[cpuInput] == "scissors" || inputArr[cpuInput] == "lizard")) || (playerOneInput == "paper" && (inputArr[cpuInput] == "rock" || inputArr[cpuInput] == "spock")) || (playerOneInput == "scissors" && (inputArr[cpuInput] == "lizard" || inputArr[cpuInput] == "paper")) || (playerOneInput == "lizard" && (inputArr[cpuInput] == "paper" || inputArr[cpuInput] == "spock")) || playerOneInput == "spock" && (inputArr[cpuInput] == "rock" || inputArr[cpuInput] == "scissors"))
            {
                Console.WriteLine($"Player 1 wins round {roundCounter + 1}!");
                playerOneScore++;
                Console.WriteLine($"P1: Score {playerOneScore}");
                if(playerOneScore == winningNumberTwo || playerOneScore == winningNumberThree)
                {
                    Console.WriteLine("Player 1 wins!");
                    roundCounter = maxRounds;
                }
                else if(roundCounter == maxRounds && playerOneScore > playerTwoScore)
                {
                    Console.WriteLine($"Player 1 wins!\nTotal Score: Player1 - {playerOneScore} CPU - {playerTwoScore}");
                }
            }
            else
            {
                Console.WriteLine(inputArr[cpuInput]);
                Console.WriteLine($"CPU wins round {roundCounter + 1}!");
                playerTwoScore++;
                Console.WriteLine($"CPU Score: {playerTwoScore}");
                if(playerTwoScore == winningNumberTwo || playerTwoScore == winningNumberThree)
                {
                    Console.WriteLine("CPU wins!");
                    roundCounter = maxRounds;
                }
                else if(roundCounter == maxRounds && playerTwoScore > playerOneScore)
                {
                    Console.WriteLine($"Player 1 wins!\nTotal Score: Player1 - {playerOneScore} CPU - {playerTwoScore}");
                }
            }
            roundCounter++;
        }
    }

    run = false;
}