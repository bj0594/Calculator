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

        Clear the console

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

        IF the button is Clear

            Clear the expression

        ELSE IF the button is Equals

            Parse the expression

            IF the expression contains two numbers

                Call the Calculate overload that takes two numbers

            ELSE IF the expression contains multiple numbers

                Create a list of numbers

                Call the Calculate overload that takes a list of numbers

            Display the result

            Wait for 2 seconds

            Clear the expression

        ELSE

            Add the selected button to the expression

            IF the expression reaches the maximum display length

                Do not add more characters

END LOOP

## END