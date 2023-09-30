using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02549Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02549();
        sut.DistinctIntegers(5).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02549();
        sut.DistinctIntegers(3).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02549();
        sut.DistinctIntegers(1).Should().Be(1);
    }
}