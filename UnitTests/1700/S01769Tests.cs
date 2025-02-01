using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01769Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01769();
        Assert.That(sut.MinOperations("110"), Is.EqualTo((int[]) [1, 1, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01769();
        Assert.That(sut.MinOperations("001011"), Is.EqualTo((int[]) [11, 8, 5, 4, 3, 4]));
    }
}