using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03512))]
public class S03512Test
{
    [Test]
    public void T1()
    {
        var sut = new S03512();
        Assert.That(sut.MinOperations([3, 9, 7], 5), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03512();
        Assert.That(sut.MinOperations([4, 1, 3], 4), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03512();
        Assert.That(sut.MinOperations([3, 2], 6), Is.EqualTo(5));
    }
}
