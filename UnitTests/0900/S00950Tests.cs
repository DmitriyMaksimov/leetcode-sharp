using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00950Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00950();
        sut.DeckRevealedIncreasing(new[] {17, 13, 11, 2, 3, 5, 7}).Should().Equal(2, 13, 3, 11, 5, 17, 7);
    }

    [Test]
    public void T2()
    {
        var sut = new S00950();
        sut.DeckRevealedIncreasing(new[] {1, 1000}).Should().Equal(1, 1000);
    }
}