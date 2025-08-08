using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02961))]
public class S02961Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02961();
        Assert.That(sut.GetGoodIndices([[2, 3, 3, 10], [3, 3, 3, 1], [6, 1, 1, 4]], 2), Is.EqualTo([0, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02961();
        Assert.That(sut.GetGoodIndices([[39, 3, 1000, 1000]], 17), Is.Empty);
    }
}