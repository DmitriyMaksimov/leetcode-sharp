using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00542Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00542();
        Assert.That(sut.UpdateMatrix([[0, 0, 0], [0, 1, 0], [0, 0, 0]]), Is.EquivalentTo([
            [0, 0, 0], [0, 1, 0], new[] {0, 0, 0}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00542();
        Assert.That(sut.UpdateMatrix([[0, 0, 0], [0, 1, 0], [1,1,1]]), Is.EquivalentTo([
            [0, 0, 0], [0, 1, 0], new[] {1, 2, 1}
        ]));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00542();
        Assert.That(sut.UpdateMatrix([[0, 0, 0], [0, 1, 0]]), Is.EquivalentTo([[0, 0, 0], new[] {0, 1, 0}]));
    }
}