using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00412Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00412();
        sut.FizzBuzz(3).Should().Equal("1", "2", "Fizz");
    }

    [Test]
    public void T2()
    {
        var sut = new S00412();
        sut.FizzBuzz(5).Should().Equal("1", "2", "Fizz", "4", "Buzz");
    }

    [Test]
    public void T3()
    {
        var sut = new S00412();
        sut.FizzBuzz(15).Should().Equal("1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz");
    }
}