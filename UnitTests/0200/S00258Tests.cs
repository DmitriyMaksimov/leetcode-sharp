using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00258Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00258();
        sut.AddDigits(38).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00258();
        sut.AddDigits(0).Should().Be(0);
    }
}