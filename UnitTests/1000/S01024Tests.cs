using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01024Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01024();
        sut.VideoStitching([[0, 2], [4, 6], [8, 10], [1, 9], [1, 5], [5, 9]], 10).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01024();
        sut.VideoStitching([[0, 1], [1, 2]], 5).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01024();
        sut.VideoStitching([[0, 1], [6, 8], [0, 2], [5, 6], [0, 4], [0, 3], [6, 7], [1, 3], [4, 7], [1, 4], [2, 5], [2, 6], [3, 4], [4, 5], [5, 7], [6, 9]], 9).Should().Be(3);
    }
}
