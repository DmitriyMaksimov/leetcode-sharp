using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03216Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03216();
        sut.GetSmallestString("45320").Should().Be("43520");
    }

    [Test]
    public void T2()
    {
        var sut = new S03216();
        sut.GetSmallestString("001").Should().Be("001");
    }
}