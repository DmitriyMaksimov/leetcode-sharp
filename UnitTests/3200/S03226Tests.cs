using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03226Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03226();
        sut.MinChanges(13, 4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S03226();
        sut.MinChanges(21, 21).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S03226();
        sut.MinChanges(14, 13).Should().Be(-1);
    }
}