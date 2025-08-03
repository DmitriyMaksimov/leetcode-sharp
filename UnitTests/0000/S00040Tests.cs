using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00040Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00040();
        Assert.That(sut.CombinationSum2([10, 1, 2, 7, 6, 1, 5], 8), Is.EquivalentTo([
            [1, 1, 6], [1, 2, 5], [1, 7], new[] {2, 6}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00040();
        Assert.That(sut.CombinationSum2([2, 5, 2, 1, 2], 5), Is.EquivalentTo([[1, 2, 2], new[] {5}]));
    }
}