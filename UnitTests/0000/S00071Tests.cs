using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00071Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00071();
        Assert.That(sut.SimplifyPath("/home/"), Is.EqualTo("/home"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00071();
        Assert.That(sut.SimplifyPath("/../"), Is.EqualTo("/"));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00071();
        Assert.That(sut.SimplifyPath("/home//foo/"), Is.EqualTo("/home/foo"));
    }
    
    [Test]
    public void T4()
    {
        var sut = new S00071();
        Assert.That(sut.SimplifyPath("/a/./b/../../c/"), Is.EqualTo("/c"));
    }
}