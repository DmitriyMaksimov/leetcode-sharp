using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02592Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02592();
        sut.MaximizeGreatness([1, 3, 5, 2, 1, 3, 1]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02592();
        sut.MaximizeGreatness([1, 2, 3, 4]).Should().Be(3);
    }
}
