using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02148Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02148();
        Assert.That(sut.CountElements([11, 7, 2, 15]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02148();
        Assert.That(sut.CountElements([-3, 3, 3, 90]), Is.EqualTo(2));
    }
}