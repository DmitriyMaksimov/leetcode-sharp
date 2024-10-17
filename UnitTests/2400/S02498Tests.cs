using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02498Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02498();
        sut.MaxJump([0, 2, 5, 6, 7]).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02498();
        sut.MaxJump([0, 3, 9]).Should().Be(9);
    }
}
