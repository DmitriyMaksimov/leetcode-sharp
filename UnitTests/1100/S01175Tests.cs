using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01175Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01175();
        Assert.That(sut.NumPrimeArrangements(5), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S01175();
        Assert.That(sut.NumPrimeArrangements(100), Is.EqualTo(682289015));
    }
}