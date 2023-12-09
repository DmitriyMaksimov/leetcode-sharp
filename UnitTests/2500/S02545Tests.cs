using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02545Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02545();
        sut.SortTheStudents(new[] {new[] {10, 6, 9, 1}, new[] {7, 5, 11, 2}, new[] {4, 8, 3, 15}}, 2).Should().BeEquivalentTo(new[]{new[] {7, 5, 11, 2}, new[] {10, 6, 9, 1}, new[] {4, 8, 3, 15}});
    }

    [Test]
    public void T2()
    {
        var sut = new S02545();
        sut.SortTheStudents(new[] {new[] {3, 4}, new[] {5, 6}}, 0).Should().BeEquivalentTo(new []{new[] {5, 6}, new[] {3, 4}});
    }
}