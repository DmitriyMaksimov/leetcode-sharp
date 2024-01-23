using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03014Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03014();
        sut.MinimumPushes("abcde").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S03014();
        sut.MinimumPushes("xycdefghij").Should().Be(12);
    }
}