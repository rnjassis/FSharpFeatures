namespace FunctionComposition

module Composition =
    let func1 x y = x - y

    3 |> func1 10 |> func1 100  //take 3, put as sencond parameter of func1 10 and the result put as the second parameter of func1 100

    func1 100 <| (func1 10 <| 3)    //same as before but in a different way

    let func2 x = x * x
    let func3 x = x * 3
    let func4 x = -x

    let func5 = func2 >> func3 >> func4 //take the result of func2 and apply on func3 and the result of this apply on func4
    func5 10


    let pair f (x:int, y:int) = f x y
    let func6 = pair func1 >> func2 //create a function that takes a tuple - pair func1 - and the result apply on func2
    func6 (10, 8)