using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00039Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00039();
        Assert.That(sut.CombinationSum([2, 3, 6, 7], 7), Is.EquivalentTo([[2, 2, 3], new[] {7}]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00039();
        Assert.That(sut.CombinationSum([2, 3, 5], 8), Is.EquivalentTo([
            [2, 2, 2, 2], [2, 3, 3], new[] {3, 5}
        ]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00039();
        Assert.That(sut.CombinationSum([2], 1), Is.Empty);
    }
}