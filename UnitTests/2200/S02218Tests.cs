using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02218Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02218();
        Assert.That(sut.MaxValueOfCoins(new List<IList<int>> {new List<int> {1, 100, 3}, new List<int> {7, 8, 9}}, 2), Is.EqualTo(101));
    }

    [Test]
    public void T2()
    {
        var sut = new S02218();
        Assert.That(sut.MaxValueOfCoins(
            new List<IList<int>>
            {
                new List<int> {100}, new List<int> {100}, new List<int> {100}, new List<int> {100}, new List<int> {100}, new List<int> {100}, new List<int> {1, 1, 1, 1, 1, 1, 700},
            }, 7), Is.EqualTo(706));
    }
}