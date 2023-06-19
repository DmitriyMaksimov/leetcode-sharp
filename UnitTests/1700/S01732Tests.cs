using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01732Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01732();
        sut.LargestAltitude(new[] {-5, 1, 5, 0, -7}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01732();
        sut.LargestAltitude(new[] {-4, -3, -2, -1, 4, 3, 2}).Should().Be(0);
    }
}