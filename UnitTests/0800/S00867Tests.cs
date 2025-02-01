using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00867Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00867();
        Assert.That(sut.Transpose(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}}), Is.EquivalentTo(new[]{new[] {1, 4, 7}, new[] {2, 5, 8}, new[] {3, 6, 9}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00867();
        Assert.That(sut.Transpose(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}}), Is.EquivalentTo(new[]{new[] {1, 4}, new[] {2, 5}, new[] {3, 6}}));
    }

}