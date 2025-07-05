using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03591))]
public class S03591Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03591();
        Assert.That(sut.CheckPrimeFrequency([1, 2, 3, 4, 5, 4]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03591();
        Assert.That(sut.CheckPrimeFrequency([1, 2, 3, 4, 5]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03591();
        Assert.That(sut.CheckPrimeFrequency([2, 2, 2, 4, 4]), Is.True);
    }
}