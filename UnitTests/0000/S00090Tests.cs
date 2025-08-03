using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00090Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00090();
        Assert.That(sut.SubsetsWithDup([1, 2, 2]), Is.EquivalentTo([
            [],
            [1], [2], [1, 2], [2, 2], new[] {1, 2, 2}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00090();
        Assert.That(sut.SubsetsWithDup([0]), Is.EquivalentTo([[], new[] {0}]));
    }
}