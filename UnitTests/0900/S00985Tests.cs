using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00985Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00985();
        sut.SumEvenAfterQueries([1, 2, 3, 4], [[1, 0], [-3, 1], [-4, 0], [2, 3]]).Should().Equal(8, 6, 2, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00985();
        sut.SumEvenAfterQueries([1], [[4, 0]]).Should().Equal(0);
    }
}
