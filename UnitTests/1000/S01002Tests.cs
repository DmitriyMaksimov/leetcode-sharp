using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01002Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01002();
        sut.CommonChars(new[] {"bella", "label", "roller"}).Should().Equal("e", "l", "l");
    }

    [Test]
    public void T2()
    {
        var sut = new S01002();
        sut.CommonChars(new[] {"cool", "lock", "cook"}).Should().Equal("c", "o");
    }
}