using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00684Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00684();
        sut.FindRedundantConnection([[1, 2], [1, 3], [2, 3]]).Should().Equal(2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00684();
        sut.FindRedundantConnection([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]]).Should().Equal(1, 4);
    }
}
