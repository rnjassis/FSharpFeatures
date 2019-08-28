namespace TestUsingDifferentFrameworks

module ProgramToTest = 
    let rec gcd a b =
        if b = 0
            then a
            else gcd b (a % b)