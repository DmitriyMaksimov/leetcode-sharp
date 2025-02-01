using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02442Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02442();
        Assert.That(sut.CountDistinctIntegers(new[] {1, 13, 10, 12, 31}), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02442();
        Assert.That(sut.CountDistinctIntegers(new[] {2, 2, 2}), Is.EqualTo(1));
    }
}