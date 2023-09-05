using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00905Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00905();
        sut.SortArrayByParity(new[] {3, 1, 2, 4}).Should().Equal(2, 4, 1, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00905();
        sut.SortArrayByParity(new[] {0}).Should().Equal(0);
    }
}