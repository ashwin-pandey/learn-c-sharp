# Control Flow Statements

## Decision Making (IF Statements)

Basically when a programs runs, it runs from top to bottom in a flow,
but using control flow statements, it can be manipulated and the flow can be broken.

For decision making " if " keyword is reserved. And it expects an expression - boolean expression, it's a type of expression that gets evaluated to give boolean value, which is either "true" or "false", and that's how it is determined weather to execute the current block of code or not.

An else statement can also be written in case the the if statement gets a false value.

```
if (true) 
{
    Console.WriteLine("Inside if statement!");
} 
else 
{
    Console.WriteLine("Inside else statement!");
}
```

In the above code else statement will never be executed because if statement has the value true.

There can be any number of if-else statements in a method.