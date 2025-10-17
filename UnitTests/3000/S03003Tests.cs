using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03003))]
public class S03003Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03003();
        Assert.That(sut.MaxPartitionsAfterOperations("accca", 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03003();
        Assert.That(sut.MaxPartitionsAfterOperations("aabaab", 3), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03003();
        Assert.That(sut.MaxPartitionsAfterOperations("xxyz", 1), Is.EqualTo(4));
    }
}