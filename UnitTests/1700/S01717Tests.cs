using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01717Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01717();
        sut.MaximumGain("cdbcbbaaabab", 4, 5).Should().Be(19);
    }

    [Test]
    public void T2()
    {
        var sut = new S01717();
        sut.MaximumGain("aabbaaxybbaabb", 5, 4).Should().Be(20);
    }
}