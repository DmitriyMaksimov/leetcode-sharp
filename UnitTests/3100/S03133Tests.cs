using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03133Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03133();
        sut.MinEnd(3, 4).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S03133();
        sut.MinEnd(2, 7).Should().Be(15);
    }
}