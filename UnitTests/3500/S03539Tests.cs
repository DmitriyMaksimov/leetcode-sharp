using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03539))]
public class S03539Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03539();
        Assert.That(sut.MagicalSum(5, 5, [1, 10, 100, 10000, 1000000]), Is.EqualTo(991600007));
    }

    [Test]
    public void T2()
    {
        var sut = new S03539();
        Assert.That(sut.MagicalSum(2, 2, [5, 4, 3, 2, 1]), Is.EqualTo(170));
    }

    [Test]
    public void T3()
    {
        var sut = new S03539();
        Assert.That(sut.MagicalSum(1, 1, [28]), Is.EqualTo(28));
    }

    [Test]
    public void T4()
    {
        var sut = new S03539();
        Assert.That(
            sut.MagicalSum(30, 30,
            [
                100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000,
                100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000,
                100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000, 100000000,
                100000000, 100000000, 100000000, 100000000, 100000000
            ]), Is.EqualTo(565788921));
    }

    [Test]
    public void T5()
    {
        var sut = new S03539();
        Assert.That(sut.MagicalSum(10, 2, [27,33,76,16,9,36,22,27,5,45]), Is.EqualTo(803017482));
    }
}