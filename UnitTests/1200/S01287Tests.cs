using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01287Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01287();
        Assert.That(sut.FindSpecialInteger(new[] {1, 2, 2, 6, 6, 6, 6, 7, 10}), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S01287();
        Assert.That(sut.FindSpecialInteger(new[] {1, 1}), Is.EqualTo(1));
    }
}