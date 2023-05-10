using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00071Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00071();
        sut.SimplifyPath("/home/").Should().Be("/home");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00071();
        sut.SimplifyPath("/../").Should().Be("/");
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00071();
        sut.SimplifyPath("/home//foo/").Should().Be("/home/foo");
    }
    
    [Test]
    public void T4()
    {
        var sut = new S00071();
        sut.SimplifyPath("/a/./b/../../c/").Should().Be("/c");
    }
}