using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00496Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00496();
        Assert.That(sut.NextGreaterElement([4, 1, 2], [1, 3, 4, 2]), Is.EqualTo((int[]) [-1, 3, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00496();
        Assert.That(sut.NextGreaterElement([2, 4], [1, 2, 3, 4]), Is.EqualTo((int[]) [3, -1]));
    }
}