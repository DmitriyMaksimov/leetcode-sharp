using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01806Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01806();
        sut.ReinitializePermutation(2).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01806();
        sut.ReinitializePermutation(4).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01806();
        sut.ReinitializePermutation(6).Should().Be(4);
    }
}