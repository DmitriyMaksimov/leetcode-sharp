using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00011Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00011();
        sut.MaxArea(new[] {1, 8, 6, 2, 5, 4, 8, 3, 7}).Should().Be(49);
    }

    [Test]
    public void T2()
    {
        var sut = new S00011();
        sut.MaxArea(new[] {1, 1}).Should().Be(1);
    }
}