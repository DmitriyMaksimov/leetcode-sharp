using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01611Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01611();
        sut.MinimumOneBitOperations(3).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01611();
        sut.MinimumOneBitOperations(6).Should().Be(4);
    }
}