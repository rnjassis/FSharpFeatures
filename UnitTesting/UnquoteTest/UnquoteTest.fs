namespace TestUsingDifferentFrameworks

open Swensen.Unquote
open NUnit.Framework
open ProgramToTest

module Say =
    [<Test>]
    let ``gcd of 18 and 42 is 6 (Unquote)`` () =
        let result = gcd 18 42

        test <@ result = 6 @>
