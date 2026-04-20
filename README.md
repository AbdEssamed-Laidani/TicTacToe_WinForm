# TicTacToe WinForms

A simple Tic-Tac-Toe desktop game built with **C# Windows Forms** targeting **.NET Framework 4.8**.

## What this project does

- Runs a local 2-player Tic-Tac-Toe game (Player 1 = X, Player 2 = O)
- Uses a 3×3 board with clickable cells
- Shows whose turn it is
- Detects wins on rows, columns, and diagonals
- Highlights winning cells in green
- Detects draw when all 9 moves are used without a winner
- Includes a **Reset Game** button to start over

## Tech stack

- C#
- Windows Forms (.NET Framework 4.8)
- MaterialSkin (`MaterialSkin.2` package)

## Project structure

- `Program.cs` — application entry point
- `Form1.cs` — game logic (turn handling, board updates, win/draw checks, reset)
- `Form1.Designer.cs` — UI layout and event wiring
- `Resources/` — board/background and X/O/question mark images

## How to run

1. Open `TicTacToe.sln` in Visual Studio on Windows.
2. Restore NuGet packages.
3. Build and run the project.

## Notes

- This is a single-form desktop application.
- The game state is not persisted between runs.
