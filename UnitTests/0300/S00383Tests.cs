using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00383Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00383();
        Assert.That(sut.CanConstruct("a", "b"), Is.False);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00383();
        Assert.That(sut.CanConstruct("aa", "ab"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00383();
        Assert.That(sut.CanConstruct("aa", "aab"), Is.True);
    }
}
