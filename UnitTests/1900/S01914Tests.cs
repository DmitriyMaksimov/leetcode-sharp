using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01914Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01914();
        Assert.That(sut.RotateGrid([[40, 10], [30, 20]], 1), Is.EqualTo([(int[]) [10, 20], [40, 30]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01914();
        Assert.That(sut.RotateGrid([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]], 2),
            Is.EqualTo([(int[]) [3, 4, 8, 12], [2, 11, 10, 16], [1, 7, 6, 15], [5, 9, 13, 14]]));
    }
}
