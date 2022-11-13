using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00171UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00171();

        sut.TitleToNumber("A").Should().Be(1);
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00171();

        sut.TitleToNumber("AB").Should().Be(28);
    }
    
    [Test]
    public void Test3()
    {
        var sut = new S00171();

        sut.TitleToNumber("ZY").Should().Be(701);
    }
}