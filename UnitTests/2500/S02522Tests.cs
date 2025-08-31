using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02522))]
public class S02522Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02522();
        Assert.That(sut.MinimumPartition("165462", 60), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02522();
        Assert.That(sut.MinimumPartition("238182", 5), Is.EqualTo(-1));
    }
}