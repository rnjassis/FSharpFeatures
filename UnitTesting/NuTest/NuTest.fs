namespace TestUsingDifferentFrameworks

open NUnit.Framework
open ProgramToTest

module NuTesting =
    [<Test>]
    let ``gcd of 18 and 42 is 6`` () =
        let result = gcd 18 42
        Assert.That(result, Is.EqualTo 6)
