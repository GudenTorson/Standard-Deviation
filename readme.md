# Standard Deviation
 **An console application for Windows that calculates the standard deviation for a set of values.**
 ---
 Features
* Interpreters multiplication sign (`*`) as `VALUE*FREQUENCY`
* Supports launch with arguments
* Supports launch without arguments
* Outputs sum, average and median
* More coming soon.

### Input syntax
An input string follows the syntax: `item1, item2, item3...`

An item is a value with an optionally provided frequency. An item follows the syntax: `VALUE*FREQUENCY`

E.g.

The input `23,56*3,45` would be interpreted as the following list:
|Values|
|-----:|
|23    |
|56    |
|56    |
|56    |
|45    |

### Startup argument syntax
`Standard-Deviation-X-X.exe -L item1, item2, item3...`

E.g.

`Standarad-Deviation-0-3.exe -L 23,56*3,45`
