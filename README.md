# SudokuSolver
Supports solving of sudoku puzzles

- Easyly enter a Sudoku puzzle by mouse
- create new puzzles automatically
- notations about possible Digits without pencil (with right-click)
- set and wipe digits for field (with left-click)
- help button which unlocks one digit in a field
- rollback feature for experimental approach
- Load / save game
- complete solution on demand with one klick
- automatically or manually wipe out obsolete possible digits by rules:
  - search for single digit in row
  - search for single digit in column
  - search for single digit in 9x9 carret
  - if all species of a digit reside on one line of a carret, the remaining line cannot contain this digit
  - if all species of a digit reside on one row of a carret, the remaining row cannot contain this digit
  - if a pair of same digits with no other possible digits in their fields reside on a row, all other fields of that row cannot contain this pair of digits
  - if a pair of same digits with no other possible digits in their fields reside on a column, all other fields of that column cannot contain this pair of digits
  - if a pair of same digits with no other possible digits in their fields reside within a carret, all other fields of that carret cannot contain this pair of digits
  - if a closed group of n digits resides n times in a row all other fields of this row cannot contain the n digits
  - if a closed group of n digits resides n times in a column all other fields of this column cannot contain the n digits

