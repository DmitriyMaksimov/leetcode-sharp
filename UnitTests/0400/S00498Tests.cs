using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00498Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00498();
        Assert.That(sut.FindDiagonalOrder([[1, 2, 3], [4, 5, 6], [7, 8, 9]]), Is.EqualTo((int[]) [1, 2, 4, 7, 5, 3, 6, 8, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00498();
        Assert.That(sut.FindDiagonalOrder([[1, 2], [3, 4]]), Is.EqualTo((int[]) [1, 2, 3, 4]));
    }
}
