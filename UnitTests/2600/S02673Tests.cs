using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02673Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02673();
        sut.MinIncrements(7, [1, 5, 2, 2, 3, 3, 1]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02673();
        sut.MinIncrements(3, [5, 3, 3]).Should().Be(0);
    }
}
