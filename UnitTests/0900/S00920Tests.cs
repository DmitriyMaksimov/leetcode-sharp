using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00920Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00920();
        Assert.That(sut.NumMusicPlaylists(3, 3, 1), Is.EqualTo(6));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00920();
        Assert.That(sut.NumMusicPlaylists(2, 3, 0), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S00920();
        Assert.That(sut.NumMusicPlaylists(2, 3, 1), Is.EqualTo(2));
    }

}