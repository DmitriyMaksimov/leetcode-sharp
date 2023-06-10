using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01720Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01720();
        sut.Decode(new[] {1, 2, 3}, 1).Should().Equal(1, 0, 2, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01720();
        sut.Decode(new[] {6, 2, 7, 3}, 4).Should().Equal(4, 2, 0, 7, 4);
    }
}