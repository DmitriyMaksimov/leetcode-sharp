using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02748Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02748();
        Assert.That(sut.CountBeautifulPairs([2, 5, 1, 4]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02748();
        Assert.That(sut.CountBeautifulPairs([11, 21, 12]), Is.EqualTo(2));
    }
}