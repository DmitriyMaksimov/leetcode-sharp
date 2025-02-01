using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01317Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01317();
        Assert.That(sut.GetNoZeroIntegers(2), Is.EqualTo((int[]) [1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01317();
        Assert.That(sut.GetNoZeroIntegers(11), Is.EqualTo((int[]) [2, 9]));
    }
}