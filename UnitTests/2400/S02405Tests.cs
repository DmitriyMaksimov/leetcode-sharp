using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02405Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02405();
        Assert.That(sut.PartitionString("abacaba"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02405();
        Assert.That(sut.PartitionString("ssssss"), Is.EqualTo(6));
    }
}