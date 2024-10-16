using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01884Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01884();
        sut.TwoEggDrop(2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01884();
        sut.TwoEggDrop(100).Should().Be(14);
    }
}