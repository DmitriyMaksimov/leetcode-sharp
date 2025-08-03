using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00766Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00766();
        Assert.That(sut.IsToeplitzMatrix([[1, 2, 3, 4], [5, 1, 2, 3], [9, 5, 1, 2]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00766();
        Assert.That(sut.IsToeplitzMatrix([[1, 2], [2, 2]]), Is.False);
    }
}
