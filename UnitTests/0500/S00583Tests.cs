using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00583Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00583();
        sut.MinDistance("sea", "eat").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00583();
        sut.MinDistance("leetcode", "etco").Should().Be(4);
    }
}
