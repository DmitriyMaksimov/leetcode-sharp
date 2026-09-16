using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01621))]
public class S01621Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01621();
        Assert.That(sut.NumberOfSets(4, 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01621();
        Assert.That(sut.NumberOfSets(3, 1), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01621();
        Assert.That(sut.NumberOfSets(30, 7), Is.EqualTo(796297179));
    }
}