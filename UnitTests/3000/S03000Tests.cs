using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03000Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03000();
        Assert.That(sut.AreaOfMaxDiagonal([[9, 3], [8, 6]]), Is.EqualTo(48));
    }

    [Test]
    public void T2()
    {
        var sut = new S03000();
        Assert.That(sut.AreaOfMaxDiagonal([[3, 4], [4, 3]]), Is.EqualTo(12));
    }
}