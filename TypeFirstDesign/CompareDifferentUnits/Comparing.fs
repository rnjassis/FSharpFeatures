namespace CompareDifferentUnits

module Comparing = 
    type CheckingAccount = CheckingAccount
    [<Measure>] type money          //Creating a unit of measure called money
    type Deposit = decimal<money>   //adding the metadata saying the unit of measure of this decimal 

    let openCheckingAccount (deposit: Deposit) =
        if deposit >= 500M<money>   //500M is decimal but doesnt have a unit of measure, so it have to have the measurement decorator
            then Some CheckingAccount
            else None
    openCheckingAccount 100M<money>

module DifferentUnitis = 
    [<Measure>] type meter
    [<Measure>] type second

    let someMeter = 12.3<meter>
    let someSecond = 45.6<second>

    someMeter * 1.0 //is ok
    let velocity = someMeter / someSecond // return a new unit o measure: meter/second
    someMeter * velocity    // return a new unit of measure meter^2/second
    someSecond * velocity   //return meter

    let double (fl: float<_>) = //<_> means it doesnt matter the measure
        fl + fl