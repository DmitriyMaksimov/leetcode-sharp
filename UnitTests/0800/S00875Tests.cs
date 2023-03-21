using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00875Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00875();
        sut.MinEatingSpeed(new[] {3, 6, 7, 11}, 8).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00875();
        sut.MinEatingSpeed(new[] {30, 11, 23, 4, 20}, 5).Should().Be(30);
    }

    [Test]
    public void T3()
    {
        var sut = new S00875();
        sut.MinEatingSpeed(new[] {30, 11, 23, 4, 20}, 6).Should().Be(23);
    }
}