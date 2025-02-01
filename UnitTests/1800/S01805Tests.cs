using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01805Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01805();
        Assert.That(sut.NumDifferentIntegers("a123bc34d8ef34"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01805();
        Assert.That(sut.NumDifferentIntegers("leet1234code234"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01805();
        Assert.That(sut.NumDifferentIntegers("a1b01c001"), Is.EqualTo(1));
    }
}