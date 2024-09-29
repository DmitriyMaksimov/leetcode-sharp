using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02177Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02177();
        sut.SumOfThree(33).Should().Equal(10, 11, 12);
    }

    [Test]
    public void T2()
    {
        var sut = new S02177();
        sut.SumOfThree(4).Should().Equal();
    }
}
