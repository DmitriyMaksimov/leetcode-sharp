using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03325Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03325();
        sut.NumberOfSubstrings("abacb", 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03325();
        sut.NumberOfSubstrings("abcde", 1).Should().Be(15);
    }
}
