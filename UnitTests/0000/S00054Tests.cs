using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00054Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00054();
        Assert.That(sut.SpiralOrder(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}}), Is.EqualTo((int[]) [1, 2, 3, 6, 9, 8, 7, 4, 5]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00054();
        Assert.That(sut.SpiralOrder(new[] {new[] {1, 2, 3, 4}, new[] {5, 6, 7, 8}, new[] {9, 10, 11, 12}}), Is.EqualTo((int[]) [1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7]));
    }
}