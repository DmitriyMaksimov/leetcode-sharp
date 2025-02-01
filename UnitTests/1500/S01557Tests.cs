using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01557Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01557();
        Assert.That(sut.FindSmallestSetOfVertices(6, new List<IList<int>> {new List<int> {0, 1}, new List<int> {0, 2}, new List<int> {2, 5}, new List<int> {3, 4}, new List<int> {4, 2}}), Is.EqualTo((int[]) [0, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01557();
        Assert.That(sut.FindSmallestSetOfVertices(5, new List<IList<int>> {new List<int> {0, 1}, new List<int> {2, 1}, new List<int> {3, 1}, new List<int> {1, 4}, new List<int> {2, 4}}), Is.EqualTo((int[]) [0, 2, 3]));
    }
}