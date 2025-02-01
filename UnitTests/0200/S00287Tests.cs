using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00287Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00287();
        Assert.That(sut.FindDuplicate(new[] {1, 3, 4, 2, 2}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00287();
        Assert.That(sut.FindDuplicate(new[] {3, 1, 3, 4, 2}), Is.EqualTo(3));
    }
}