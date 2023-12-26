using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01155Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01155();
        sut.NumRollsToTarget(1, 6, 3).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01155();
        sut.NumRollsToTarget(2, 6, 7).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S01155();
        sut.NumRollsToTarget(30, 30, 500).Should().Be(222616187);
    }
}