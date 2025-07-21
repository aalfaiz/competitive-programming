# Provide steps how to run competitive programming exercises locally using visual studio code

[✔] Syntax Highlighter

[✔] Debugable

## Requirements
1. Install .NET 8
2. Install dotnet-script

    `dotnet tool install -g dotnet-script`

3. Install vs code Extensions
    - leetcode (if using leetcode to get exercise information)
    - C# (syntax checker)
    - Error Lens (inline error)
    - CSharpier (code formatter)


## How to leetcode
1. Login into leetcode from vscode
2. Search for exercise ([1] Two Sum)
3. Select "just open the problem file"
4. Save as in leetcode folder as csharp script [FileName].csx
5. Configure the file to run with local unit test (see 1.Two-Sum.csx)
6. Run using vs code run command (F5). To debug, just put breakpoint in the test case
7. To Submit the exercise Open Leetcode extension on the left menu and keep it open
8. on the below of `Solution` class, there will be options to submit or test online
