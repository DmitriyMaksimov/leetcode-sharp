using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00867Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00867();
        Assert.That(sut.Transpose([[1, 2, 3], [4, 5, 6], [7, 8, 9]]), Is.EquivalentTo([
            [1, 4, 7], [2, 5, 8], new[] {3, 6, 9}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00867();
        Assert.That(sut.Transpose([[1, 2, 3], [4, 5, 6]]), Is.EquivalentTo([[1, 4], [2, 5], new[] {3, 6}]));
    }

}