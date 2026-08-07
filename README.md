# Terminal Calculator

## START

Create the calculator interface

Set selected row to 3

Set selected column to 0

Create an empty expression

## LOOP

    Clear the console

    Draw the calculator
        Display the current expression
        Highlight the selected button

    Wait for keyboard input

    IF Escape is pressed

        End the program

    ELSE IF Up Arrow is pressed

        IF row is greater than 0

            Move selection up

    ELSE IF Down Arrow is pressed

        IF row is less than 3

            Move selection down

    ELSE IF Left Arrow is pressed

        IF column is greater than 0

            Move selection left

    ELSE IF Right Arrow is pressed

        IF column is less than 3

            Move selection right

    ELSE IF Enter is pressed

        Read the selected button

        IF the button is a number

            Add it to the expression

        ELSE IF the button is an operator

            Add it to the expression

        ELSE IF the button is Clear

            Clear the expression

        ELSE IF the button is Equals

            Evaluate the expression

            Display the result

## END LOOP

## END