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

    ELSE IF an Arrow key is pressed

        IF the movement is within the calculator borders

            Update row or column

    ELSE IF Enter is pressed

        Read the selected button

        IF the button is Clear

            Clear the expression

        ELSE IF the button is Equals

            Parse the expression

            Count the unique operators

            IF there is more than one unique operator

                Display "Error"

            ELSE

                Count the numbers

                IF there are two numbers

                    Call the Calculate overload
                    that takes two numbers

                ELSE IF there are more than two numbers

                    Create a List<double> of numbers

                    Call the Calculate overload
                    that takes a List<double>

                Display the result

            Wait for 2 seconds

            Clear the expression

        ELSE

            IF the expression has not reached
            the maximum display length

                Add the selected button to the expression

END LOOP

## END