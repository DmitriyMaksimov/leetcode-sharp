using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02766Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02766();
        sut.RelocateMarbles([1, 6, 7, 8], [1, 7, 2], [2, 9, 5]).Should().Equal(5, 6, 8, 9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02766();
        sut.RelocateMarbles([1, 1, 3, 3], [1, 3], [2, 2]).Should().Equal(2);
    }
}
