using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02139Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02139();
        sut.MinMoves(5, 0).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02139();
        sut.MinMoves(19, 2).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S02139();
        sut.MinMoves(10, 4).Should().Be(4);
    }
}
