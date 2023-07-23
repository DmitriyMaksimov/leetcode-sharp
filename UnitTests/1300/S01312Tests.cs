using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01312Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01312();
        sut.MinInsertions("zzazz").Should().Be(0);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01312();
        sut.MinInsertions("mbadm").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01312();
        sut.MinInsertions("leetcode").Should().Be(5);
    }
}