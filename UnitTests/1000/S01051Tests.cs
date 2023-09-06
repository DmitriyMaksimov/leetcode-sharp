using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01051Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01051();
        sut.HeightChecker(new[] {1, 1, 4, 2, 1, 3}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01051();
        sut.HeightChecker(new[] {5, 1, 2, 3, 4}).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01051();
        sut.HeightChecker(new[] {1, 2, 3, 4, 5}).Should().Be(0);
    }
}