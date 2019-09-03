namespace DomainModeling

open System

module tuples =
    let tuple1 = (5, 10)
    let tuple2 = (4,4,"A random text")

    let tupleFunc (x, y) = 
        (x+y, x*y)

    tuple1 |> tupleFunc

    let x, y = tuple1

    let tuple3 = (5,10)
    tuple1 = tuple3
    tuple1 < (5,11)

    //it is saved on the call stack instead of the heap stack
    let tuple4  = struct (1,1)

module records = 
    [<Struct>]
    type PersonRecord =
        {
            FirstName : string
            LastName : string
            Age : int
        }

    let ricardo =
    {
        FirstName = "Ricardo"
        LastName = ""
        Age = 17
    }
    
    let func1 person =
        (person.FirstName, person.Age)

    printf "end"


module DiscriminateUnion =
    type TrafficSignals = 
        | Red
        | Yellow
        | Green

    type MessageState =
        | OFF
        | Activating of WhenActivated : DateTime
        | Idle of IdleDuration : TimeSpan
        | MessageReceived of Message : string * WhenReceived : DateTime
        | Deactivating of WhenDeactivatted : DateTime

module Options =
    let safeDivide (x,y) =
        if y = 0.0
            then None
            else Some(x/y)
