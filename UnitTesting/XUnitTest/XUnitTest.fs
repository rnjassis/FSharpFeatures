namespace TestUsingDifferentFrameworks

open Xunit
open ProgramToTest
(* install xunit dependency using the nuget console:
Install-Package xunit.runner.visualstudio -Version 2.4.1 *)
module XUnitTest =
    [<Fact>]
    let ``gcd of 18 and 42 is 6 (XUnit)`` () =
        let result = gcd 18 42
        Assert.Equal(result, 6)
