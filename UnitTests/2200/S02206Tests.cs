using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02206Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02206();
        Assert.That(sut.DivideArray(new[] {3, 2, 3, 2, 2, 2}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02206();
        Assert.That(sut.DivideArray(new[] {1, 2, 3, 4}), Is.False);
    }
}
