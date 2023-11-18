using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02859Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02859();
        sut.SumIndicesWithKSetBits(new[] {5, 10, 1, 5, 2}, 1).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S02859();
        sut.SumIndicesWithKSetBits(new[] {4, 3, 2, 1}, 2).Should().Be(1);
    }
}