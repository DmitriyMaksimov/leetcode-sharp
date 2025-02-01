using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00841Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00841();
        Assert.That(sut.CanVisitAllRooms(new List<IList<int>> {new List<int> {1}, new List<int> {2}, new List<int> {3}, new List<int>()}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00841();
        Assert.That(sut.CanVisitAllRooms(new List<IList<int>> {new List<int> {1, 3}, new List<int> {3, 0, 1}, new List<int> {2}, new List<int> {0}}), Is.False);
    }
}
