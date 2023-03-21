using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01833Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01833();
        sut.MaxIceCream(new[] {1, 3, 2, 4, 1}, 7).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01833();
        sut.MaxIceCream(new[] {10, 6, 8, 7, 7, 8}, 5).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01833();
        sut.MaxIceCream(new[] {1, 6, 3, 1, 2, 5}, 20).Should().Be(6);
    }
}