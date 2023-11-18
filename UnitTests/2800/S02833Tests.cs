using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02833Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02833();
        sut.FurthestDistanceFromOrigin("L_RL__R").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02833();
        sut.FurthestDistanceFromOrigin("_R__LL_").Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S02833();
        sut.FurthestDistanceFromOrigin("_______").Should().Be(7);
    }
}