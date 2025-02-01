using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02150Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02150();
        Assert.That(sut.FindLonely([10, 6, 5, 8]), Is.EqualTo((int[]) [10, 8]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02150();
        Assert.That(sut.FindLonely([1, 3, 5, 3]), Is.EqualTo((int[]) [1, 5]));
    }
}
