using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03223Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03223();
        sut.MinimumLength("abaacbcbb").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S03223();
        sut.MinimumLength("aa").Should().Be(2);
    }
}
