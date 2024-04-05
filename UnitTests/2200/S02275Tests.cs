using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02275Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02275();
        sut.LargestCombination([16, 17, 71, 62, 12, 24, 14]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02275();
        sut.LargestCombination([8, 8]).Should().Be(2);
    }
}