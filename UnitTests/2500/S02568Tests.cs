using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02568Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02568();
        sut.MinImpossibleOR([2, 1]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02568();
        sut.MinImpossibleOR([5, 3, 2]).Should().Be(1);
    }
}
