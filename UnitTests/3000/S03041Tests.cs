using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03041))]
public class S03041Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03041();
        Assert.That(sut.MaxSelectedElements([2, 1, 5, 1, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03041();
        Assert.That(sut.MaxSelectedElements([1, 4, 7, 10]), Is.EqualTo(1));
    }
}