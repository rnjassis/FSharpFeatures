namespace TestUsingDifferentFrameworks

open FsUnit
open Xunit
open ProgramToTest

module Say =
    [<Fact>]
    let ``gcd of 18 and 42 is 6(FSUnit)`` () =
        let result = gcd 18 42
        result |> should equal 6
