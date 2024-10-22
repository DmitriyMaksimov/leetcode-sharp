using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01798Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01798();
        sut.GetMaximumConsecutive([1, 3]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01798();
        sut.GetMaximumConsecutive([1, 1, 1, 4]).Should().Be(8);
    }

    [Test]
    public void T3()
    {
        var sut = new S01798();
        sut.GetMaximumConsecutive([1, 4, 10, 3, 1]).Should().Be(20);
    }
}
