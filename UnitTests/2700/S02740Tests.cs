using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02740Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02740();
        Assert.That(sut.FindValueOfPartition([1, 3, 2, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02740();
        Assert.That(sut.FindValueOfPartition([100, 1, 10]), Is.EqualTo(9));
    }
}
