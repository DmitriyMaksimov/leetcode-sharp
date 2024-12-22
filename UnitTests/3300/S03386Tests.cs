using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03386Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03386();
        sut.ButtonWithLongestTime([[1, 2], [2, 5], [3, 9], [1, 15]]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03386();
        sut.ButtonWithLongestTime([[10, 5], [1, 7]]).Should().Be(10);
    }

    [Test]
    public void T3()
    {
        var sut = new S03386();
        sut.ButtonWithLongestTime([[7, 1], [19, 3], [9, 4], [12, 5], [2, 8], [15, 10], [18, 12], [7, 14], [19, 16]]).Should().Be(2);
    }

    [Test]
    public void T4()
    {
        var sut = new S03386();
        sut.ButtonWithLongestTime([[9, 4], [19, 5], [2, 8], [3, 11], [2, 15]]).Should().Be(2);
    }
}
