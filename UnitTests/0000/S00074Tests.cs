using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00074Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00074();
        Assert.That(sut.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00074();
        Assert.That(sut.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13), Is.False);
    }
}
