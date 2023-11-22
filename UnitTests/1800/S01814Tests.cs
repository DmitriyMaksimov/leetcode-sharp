using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01814Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01814();
        sut.CountNicePairs(new[] {42, 11, 1, 97}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01814();
        sut.CountNicePairs(new[] {13, 10, 35, 24, 76}).Should().Be(4);
    }
}