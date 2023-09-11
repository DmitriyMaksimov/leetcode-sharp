using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01805Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01805();
        sut.NumDifferentIntegers("a123bc34d8ef34").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01805();
        sut.NumDifferentIntegers("leet1234code234").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01805();
        sut.NumDifferentIntegers("a1b01c001").Should().Be(1);
    }
}