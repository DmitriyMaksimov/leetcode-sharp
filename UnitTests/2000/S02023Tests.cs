using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02023Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02023();
        Assert.That(sut.NumOfPairs(["123", "4", "12", "34"], "1234"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02023();
        Assert.That(sut.NumOfPairs(["777", "7", "77", "77"], "7777"), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02023();
        Assert.That(sut.NumOfPairs(["1", "1", "1"], "11"), Is.EqualTo(6));
    }
}