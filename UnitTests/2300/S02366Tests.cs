using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02366Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02366();
        sut.MinimumReplacement(new[] {1, 2, 3, 4, 5}).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02366();
        sut.MinimumReplacement(new[] {3, 9, 3}).Should().Be(2);
    }
}