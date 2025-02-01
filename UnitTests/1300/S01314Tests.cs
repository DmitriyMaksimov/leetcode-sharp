using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01314Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01314();
        Assert.That(sut.MatrixBlockSum(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}}, 1), Is.EquivalentTo(new[] {new[] {12, 21, 16}, new[] {27, 45, 33}, new[] {24, 39, 28}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S01314();
        Assert.That(sut.MatrixBlockSum(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}}, 2), Is.EquivalentTo(new[] {new[] {45, 45, 45}, new[] {45, 45, 45}, new[] {45, 45, 45}}));
    }
}