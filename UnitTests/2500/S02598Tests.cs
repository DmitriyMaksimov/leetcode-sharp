using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02598))]
public class S02598Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02598();
        Assert.That(sut.FindSmallestInteger([1, -10, 7, 13, 6, 8], 5), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02598();
        Assert.That(sut.FindSmallestInteger([1, -10, 7, 13, 6, 8], 7), Is.EqualTo(2));
    }
}