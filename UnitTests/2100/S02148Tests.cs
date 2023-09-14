using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02148Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02148();
        sut.CountElements(new[] {11, 7, 2, 15}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02148();
        sut.CountElements(new[] {-3, 3, 3, 90}).Should().Be(2);
    }
}