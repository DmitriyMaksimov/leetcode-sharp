using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00387Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00387();
        Assert.That(sut.FirstUniqChar("leetcode"), Is.EqualTo(0));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00387();
        Assert.That(sut.FirstUniqChar("loveleetcode"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00387();
        Assert.That(sut.FirstUniqChar("aabb"), Is.EqualTo(-1));
    }
}