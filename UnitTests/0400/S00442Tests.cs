using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00442Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00442();
        sut.FindDuplicates([4, 3, 2, 7, 8, 2, 3, 1]).Should().Equal(2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00442();
        sut.FindDuplicates([1, 1, 2]).Should().Equal(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00442();
        sut.FindDuplicates([1]).Should().Equal();
    }
}