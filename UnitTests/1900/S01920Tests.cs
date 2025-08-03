using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01920Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S01920();
        Assert.That(sut.BuildArray([0, 2, 1, 5, 3, 4]), Is.EqualTo((int[]) [0, 1, 2, 4, 5, 3]));
    }

    [Test]
    public void Test2()
    {
        var sut = new S01920();
        Assert.That(sut.BuildArray([5, 0, 1, 2, 3, 4]), Is.EqualTo((int[]) [4, 5, 0, 1, 2, 3]));
    }
}