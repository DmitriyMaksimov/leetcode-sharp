using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02001Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02001();
        sut.InterchangeableRectangles([[4, 8], [3, 6], [10, 20], [15, 30]]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02001();
        sut.InterchangeableRectangles([[4, 5], [7, 8]]).Should().Be(0);
    }
}
