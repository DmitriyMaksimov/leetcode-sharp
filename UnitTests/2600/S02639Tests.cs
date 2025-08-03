using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02639Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02639();
        Assert.That(sut.FindColumnWidth([[1], [22], [333]]), Is.EqualTo((int[]) [3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02639();
        Assert.That(sut.FindColumnWidth([[-15, 1, 3], [15, 7, 12], [5, 6, -2]]), Is.EqualTo((int[]) [3, 1, 2]));
    }
}