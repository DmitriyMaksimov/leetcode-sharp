using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01403Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01403();
        sut.MinSubsequence(new[] {4, 3, 10, 9, 8}).Should().Equal(10, 9);
    }

    [Test]
    public void T2()
    {
        var sut = new S01403();
        sut.MinSubsequence(new[] {4, 4, 7, 6, 7}).Should().Equal(7, 7, 6);
    }
}