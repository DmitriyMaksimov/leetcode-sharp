using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01287Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01287();
        sut.FindSpecialInteger(new[] {1, 2, 2, 6, 6, 6, 6, 7, 10}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01287();
        sut.FindSpecialInteger(new[] {1, 1}).Should().Be(1);
    }
}