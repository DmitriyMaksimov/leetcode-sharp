using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02224Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02224();
        sut.ConvertTime("02:30", "04:35").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02224();
        sut.ConvertTime("11:00", "11:01").Should().Be(1);
    }
}