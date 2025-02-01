using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02840Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02840();
        Assert.That(sut.CheckStrings("abcdba", "cabdab"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02840();
        Assert.That(sut.CheckStrings("abe", "bea"), Is.False);
    }
}
