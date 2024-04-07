using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01860Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01860();
        sut.MemLeak(1, 2).Should().Equal(2, 1, 1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01860();
        sut.MemLeak(8, 11).Should().Equal(6, 0, 4);
    }
}