using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00704Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00704();
        Assert.That(sut.Search([-1, 0, 3, 5, 9, 12], 9), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00704();
        Assert.That(sut.Search([-1, 0, 3, 5, 9, 12], 2), Is.EqualTo(-1));
    }
}