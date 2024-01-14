using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03005Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03005();
        sut.MaxFrequencyElements(new[] {1, 2, 2, 3, 1, 4}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03005();
        sut.MaxFrequencyElements(new[] {1, 2, 3, 4, 5}).Should().Be(5);
    }
}