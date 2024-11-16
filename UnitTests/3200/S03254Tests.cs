using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03254Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03254();
        sut.ResultsArray([1, 2, 3, 4, 3, 2, 5], 3).Should().Equal(3, 4, -1, -1, -1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03254();
        sut.ResultsArray([2, 2, 2, 2, 2], 4).Should().Equal(-1, -1);
    }

    [Test]
    public void T3()
    {
        var sut = new S03254();
        sut.ResultsArray([3, 2, 3, 2, 3, 2], 2).Should().Equal(-1, 3, -1, 3, -1);
    }
}
