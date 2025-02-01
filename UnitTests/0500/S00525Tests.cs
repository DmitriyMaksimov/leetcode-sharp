using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00525Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00525();
        Assert.That(sut.FindMaxLength([0, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00525();
        Assert.That(sut.FindMaxLength([0, 1, 0]), Is.EqualTo(2));
    }
}