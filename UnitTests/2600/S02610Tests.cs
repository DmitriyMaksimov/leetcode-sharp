using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02610Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02610();
        Assert.That(sut.FindMatrix([1, 3, 4, 1, 2, 3, 1]), Is.EquivalentTo([
            [1, 3, 4, 2], [1, 3], new[] {1}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02610();
        Assert.That(sut.FindMatrix([1, 2, 3, 4]), Is.EquivalentTo([new[] {1, 2, 3, 4}]));
    }
}