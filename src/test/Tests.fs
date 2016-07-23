module Tests

module Unit =
  type TestAttribute = NUnit.Framework.TestAttribute

  let [<Test>] ``NUnit works`` () = NUnit.Framework.Assert.True true

module Exploratory =
  type TestAttribute = NUnit.Framework.TestAttribute

module Property =
  type TestAttribute = NUnit.Framework.TestAttribute
  type PerformanceTestAttribute () =
    //inherit NUnit.Framework.TestAttribute ()
    inherit NUnit.Framework.IgnoreAttribute ("Performance test")

  let property = FsCheck.Check.QuickThrowOnFailure
