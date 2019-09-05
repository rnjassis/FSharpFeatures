namespace PartialFunctions

module Partial =
    let func1 x y =
        x + y
    let func2 (x, y) = 
        x + y

    let partialFunc1 = func1 2 //partialFunc1 is func1 with 2 in the place of x
    partialFunc1 3 //returns 5

    let partialFunc2' x y =     //in the case of tuples, its needed a function that separates the variables
        func2(x, y)
    
    let partialFunc2 = partialFunc2' 2
    partialFunc2 3 //returns 5

    let mathOperation f x y =
        f x y
    let func3 = mathOperation func1
    let func4 = mathOperation (*)   //the operation of multiply