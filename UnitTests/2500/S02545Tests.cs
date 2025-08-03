using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02545Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02545();
        Assert.That(sut.SortTheStudents([[10, 6, 9, 1], [7, 5, 11, 2], [4, 8, 3, 15]], 2), Is.EquivalentTo([
            [7, 5, 11, 2], [10, 6, 9, 1], new[] {4, 8, 3, 15}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02545();
        Assert.That(sut.SortTheStudents([[3, 4], [5, 6]], 0), Is.EquivalentTo([[5, 6], new[] {3, 4}]));
    }
}