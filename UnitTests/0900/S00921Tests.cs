using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00921Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00921();
        sut.MinAddToMakeValid("())").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00921();
        sut.MinAddToMakeValid("(((").Should().Be(3);
    }
}