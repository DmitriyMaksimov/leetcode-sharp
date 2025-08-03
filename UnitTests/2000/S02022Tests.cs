using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02022Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02022();
        Assert.That(sut.Construct2DArray([1, 2, 3, 4], 2, 2), Is.EquivalentTo([[1, 2], new[] {3, 4}]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02022();
        Assert.That(sut.Construct2DArray([1, 2, 3], 1, 3), Is.EquivalentTo([new[] {1, 2, 3}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02022();
        Assert.That(sut.Construct2DArray([1, 2], 1, 1), Is.EquivalentTo(Array.Empty<int[]>()));
    }
}