using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02164Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02164();
        sut.SortEvenOdd(new[] {4, 1, 2, 3}).Should().Equal(2, 3, 4, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02164();
        sut.SortEvenOdd(new[] {2, 1}).Should().Equal(2, 1);
    }
}