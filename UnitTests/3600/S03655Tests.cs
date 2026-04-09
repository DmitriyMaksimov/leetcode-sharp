using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03655))]
public class S03655Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03655();
        Assert.That(sut.XorAfterQueries([1, 1, 1], [[0, 2, 1, 4]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03655();
        Assert.That(sut.XorAfterQueries([2, 3, 1, 5, 4], [[1, 4, 2, 3], [0, 2, 1, 2]]), Is.EqualTo(31));
    }
}