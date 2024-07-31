using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01105Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01105();
        sut.MinHeightShelves([[1, 1], [2, 3], [2, 3], [1, 1], [1, 1], [1, 1], [1, 2]], 4).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01105();
        sut.MinHeightShelves([[1, 3], [2, 4], [3, 2]], 6).Should().Be(4);
    }
}
