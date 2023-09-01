using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00575Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00575();
        sut.DistributeCandies(new[] {1, 1, 2, 2, 3, 3}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00575();
        sut.DistributeCandies(new[] {1, 1, 2, 3}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00575();
        sut.DistributeCandies(new[] {6, 6, 6, 6}).Should().Be(1);
    }
}