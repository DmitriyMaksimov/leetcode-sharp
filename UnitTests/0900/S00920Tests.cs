using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00920Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00920();
        sut.NumMusicPlaylists(3, 3, 1).Should().Be(6);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00920();
        sut.NumMusicPlaylists(2, 3, 0).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S00920();
        sut.NumMusicPlaylists(2, 3, 1).Should().Be(2);
    }

}