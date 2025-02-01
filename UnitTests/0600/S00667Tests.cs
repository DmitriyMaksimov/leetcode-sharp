using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00667Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00667();
        Assert.That(sut.ConstructArray(3, 1), Is.EqualTo((int[]) [1, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00667();
        Assert.That(sut.ConstructArray(3, 2), Is.EqualTo((int[]) [3, 1, 2]));
    }
}
