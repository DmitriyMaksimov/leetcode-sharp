using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00388))]
public class S00388Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00388();
        Assert.That(sut.LengthLongestPath("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext"), Is.EqualTo(20));
    }

    [Test]
    public void T2()
    {
        var sut = new S00388();
        Assert.That(
            sut.LengthLongestPath(
                "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext"),
            Is.EqualTo(32));
    }

    [Test]
    public void T3()
    {
        var sut = new S00388();
        Assert.That(sut.LengthLongestPath("a"), Is.EqualTo(0));
    }
}