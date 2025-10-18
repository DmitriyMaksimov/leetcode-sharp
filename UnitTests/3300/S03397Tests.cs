using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03397))]
public class S03397Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03397();
        Assert.That(sut.MaxDistinctElements([1, 2, 2, 3, 3, 4], 2), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03397();
        Assert.That(sut.MaxDistinctElements([4, 4, 4, 4], 1), Is.EqualTo(3));
    }
}