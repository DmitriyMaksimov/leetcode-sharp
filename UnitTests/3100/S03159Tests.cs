using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03159Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03159();
        sut.OccurrencesOfElement([1, 3, 1, 7], [1, 3, 2, 4], 1).Should().Equal(0, -1, 2, -1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03159();
        sut.OccurrencesOfElement([1, 2, 3], [10], 5).Should().Equal(-1);
    }
}
