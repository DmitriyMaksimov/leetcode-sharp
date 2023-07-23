using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01374Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01374();
        sut.GenerateTheString(4).Should().Be("aaab");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01374();
        sut.GenerateTheString(2).Should().Be("ab");
    }

    [Test]
    public void T3()
    {
        var sut = new S01374();
        sut.GenerateTheString(7).Should().Be("aaaaaaa");
    }
}