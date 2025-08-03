using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00057Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00057();
        Assert.That(sut.Insert([[1, 3], [6, 9]], [2, 5]), Is.EquivalentTo([[1, 5], new[] {6, 9}]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00057();
        Assert.That(sut.Insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]), Is.EquivalentTo([
            [1, 2], [3, 10], new[] {12, 16}
        ]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00057();
        Assert.That(sut.Insert([], [5, 7]), Is.EquivalentTo([new[] {5, 7}]));
    }

    [Test]
    public void T4()
    {
        var sut = new S00057();
        Assert.That(sut.Insert([[1, 5]], [2, 7]), Is.EquivalentTo([new[] {1, 7}]));
    }
}