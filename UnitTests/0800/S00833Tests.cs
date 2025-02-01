using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00833Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00833();
        Assert.That(sut.FindReplaceString("abcd", [0, 2], ["a", "cd"], ["eee", "ffff"]), Is.EqualTo("eeebffff"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00833();
        Assert.That(sut.FindReplaceString("abcd", [0, 2], ["ab", "ec"], ["eee", "ffff"]), Is.EqualTo("eeecd"));
    }
}
