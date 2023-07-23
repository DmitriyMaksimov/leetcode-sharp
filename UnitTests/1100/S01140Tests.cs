using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01140Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01140();
        sut.StoneGameII(new[] {2, 7, 9, 4, 4}).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S01140();
        sut.StoneGameII(new[] {1, 2, 3, 4, 5, 100}).Should().Be(104);
    }
}