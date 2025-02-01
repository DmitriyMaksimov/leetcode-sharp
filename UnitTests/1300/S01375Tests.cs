using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01375Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01375();
        Assert.That(sut.NumTimesAllBlue([3, 2, 4, 1, 5]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01375();
        Assert.That(sut.NumTimesAllBlue([4, 1, 2, 3]), Is.EqualTo(1));
    }
}
