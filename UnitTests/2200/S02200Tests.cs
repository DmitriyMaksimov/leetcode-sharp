using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02200Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02200();
        sut.FindKDistantIndices(new[] {3, 4, 9, 1, 3, 9, 5}, 9, 1).Should().Equal(1, 2, 3, 4, 5, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02200();
        sut.FindKDistantIndices(new[] {2, 2, 2, 2, 2}, 2, 2).Should().Equal(0, 1, 2, 3, 4);
    }
}