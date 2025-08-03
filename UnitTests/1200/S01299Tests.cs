using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01299Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01299();
        Assert.That(sut.ReplaceElements([17, 18, 5, 4, 6, 1]), Is.EqualTo((int[]) [18, 6, 6, 6, 1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01299();
        Assert.That(sut.ReplaceElements([400]), Is.EqualTo((int[]) [-1]));
    }
}