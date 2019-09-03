namespace KeyFeatures
                    //Important to remember that functions takes EXACTLY ONE argument and return EXACTLY ONE value
module Functions =
    let func1 x = // x is inferred as int
        x * x
    func1 3
    3 |> func1

    let func2 (x: float) =  // x is float
        x * x

    let func3 x : float = // the return is float
        x * x

    let func4 () = //parenthesis are the argument, the value is ignored ant the retur type is 'unit'
        printfn "Hi"

    let func5 x y = //is read as: create a function that has only x as argument 
        x * y       //and then return another function with only y as argument and then multiply
    
    //func5 11 10 can be represented as follows using partial funcion application:
    let func6 = func5 11
    func6 10

    let func7 (x, y) = //tuple
        x * y

    let fun8 () = //unit type
       (fun x-> x * x) // anonymous function

    let func9 f x = //use the function f with x as argument
        f x
    func9 (fun x-> x* x) 10
    10 |> func9 (fun x-> x * x) // same as before