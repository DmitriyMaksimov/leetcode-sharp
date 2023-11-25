using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01685Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01685();
        sut.GetSumAbsoluteDifferences(new[] {2, 3, 5}).Should().Equal(4, 3, 5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01685();
        sut.GetSumAbsoluteDifferences(new[] {1, 4, 6, 8, 10}).Should().Equal(24, 15, 13, 15, 21);
    }
}