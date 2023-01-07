using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00120Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00120();
        sut.MinimumTotal(new List<IList<int>>
        {
            new List<int> {2},
            new List<int> {3, 4},
            new List<int> {6, 5, 7},
            new List<int> {4, 1, 8, 3}
        }).Should().Be(11);
    }

    [Test]
    public void T2()
    {
        var sut = new S00120();
        sut.MinimumTotal(new List<IList<int>>
        {
            new List<int> {-10},
        }).Should().Be(-10);
    }
}