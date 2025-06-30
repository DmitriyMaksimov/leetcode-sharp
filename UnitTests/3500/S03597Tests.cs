using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03597))]
public class S03597Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03597();
        Assert.That(sut.PartitionString("abbccccd"), Is.EqualTo(["a", "b", "bc", "c", "cc", "d"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03597();
        Assert.That(sut.PartitionString("aaaa"), Is.EqualTo(["a", "aa"]));
    }
}