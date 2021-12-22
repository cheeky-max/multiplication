# Multiplication

## Description

Multiplication is a game where you have to answer multiplication questions.

It will ask you how many multiplication questions to ask you, and what's the smallest and largest numbers you want to try to multiply. It will then ask you questions and tell you if you were right or wrong. At the end, it will give you your final score.

Multiplication is written in C#.

## Building and Running

You need the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to build Multiplication, and [.NET 6 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to run it.

Run `dotnet build src` from the repository root to build Multiplication.

You can run the `Multiplication` binary from the `src/Multiplication/bin` directory, or just run `dotnet run src --project src/Multiplication` from the repository root.

## To Do

1. Add support for negative numbers.
2. Add support for (easy) real numbers.
3. Introduce mechanic of rounds, where each round gets progressively harder.
4. Maybe add support for other types of arithmetic, like addition, subtraction, and division. Does that mean I have to rename the project? 😂