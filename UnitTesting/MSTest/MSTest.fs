namespace TestUsingDifferentFrameworks

open Microsoft.VisualStudio.TestTools.UnitTesting
open ProgramToTest

[<TestClass>]
type MSTesting () =
    [<TestMethod>] 
    member x.``gcd of 18 and 42 is 16 (MSTest)`` () =
        let result = gcd 18 42
        Assert.AreEqual(result, 6)
