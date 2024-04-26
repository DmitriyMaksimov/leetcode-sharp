using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03120Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03120();
        sut.NumberOfSpecialChars("aaAbcBC").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03120();
        sut.NumberOfSpecialChars("abc").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S03120();
        sut.NumberOfSpecialChars("abBCab").Should().Be(1);
    }
}