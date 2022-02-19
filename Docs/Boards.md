## Board Analysis

Count of boards grouped by starting (upper-left) square:

```bash
~/squareful/Squareful.Web/wwwroot/boards$ cut -c 1 all.txt | uniq -c
    104 2
    388 3
   1484 4
   1794 5
   2678 6
   5278 7
   6930 8
```

Interesting to note:
- the last column of digits in the first column of numbers adds to 36, the side length of the 36x36 overall board
- the function from starting square to count is monotonically increasing

```mermaid
pie
	title Starting Square
	"2" : 104
	"3" : 388
	"4" : 1484
	"5" : 1794
	"6" : 2678
	"7" : 5278
	"8" : 6930
 ```
 