using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00387Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00387();
        sut.FirstUniqChar("leetcode").Should().Be(0);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00387();
        sut.FirstUniqChar("loveleetcode").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00387();
        sut.FirstUniqChar("aabb").Should().Be(-1);
    }
}