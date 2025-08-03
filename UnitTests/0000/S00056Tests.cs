using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00056Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00056();
        Assert.That(sut.Merge([[1, 3], [2, 6], [8, 10], [15, 18]]), Is.EquivalentTo([
            [1, 6], [8, 10], new[] {15, 18}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00056();
        Assert.That(sut.Merge([[1, 4], [4, 5]]), Is.EquivalentTo([new[] {1, 5}]));
    }
}