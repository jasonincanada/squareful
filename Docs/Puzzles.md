A quick visual pass through the boards to start thinking about a methodical puzzle generation strategy

| Board   | Notes                        |
| ------- | ---------------------------- |
| 188     | 1 surrounded by only 6,7,8   |
| 215-218 | Four symmetries of the 11x17 |
| 219-223 | Same as above                |
| 309     | 5,6,7,7                      |
| 314     | Corner shroud                |
| 342     | Narrow squeeze with 1-2-3s   |
| 423     | Big L shape                  |
| 433     | Another L shape              |
|         |                              |

Bookmark: https://squareful-dev.azurewebsites.net/show-board/558

## Ideas

### Simplest
1. Shroud the 1
2. Shroud the 4 squares surrounding the 1 (there will always be 4)

To increase difficulty, keep expanding the shroud outwards without sacrificing determinability (being able to deduce the 1x1 square location in a single step)
