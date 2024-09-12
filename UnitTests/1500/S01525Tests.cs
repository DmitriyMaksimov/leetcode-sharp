using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01525Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01525();
        sut.NumSplits("aacaba").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01525();
        sut.NumSplits("abcd").Should().Be(1);
    }
}
