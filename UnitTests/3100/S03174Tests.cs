using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03174Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03174();
        sut.ClearDigits("abc").Should().Be("abc");
    }

    [Test]
    public void T2()
    {
        var sut = new S03174();
        sut.ClearDigits("cb34").Should().Be("");
    }
}