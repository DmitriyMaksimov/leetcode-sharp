using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01415Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01415();
        sut.GetHappyString(1, 3).Should().Be("c");
    }

    [Test]
    public void T2()
    {
        var sut = new S01415();
        sut.GetHappyString(1, 4).Should().Be("");
    }

    [Test]
    public void T3()
    {
        var sut = new S01415();
        sut.GetHappyString(3, 9).Should().Be("cab");
    }
}