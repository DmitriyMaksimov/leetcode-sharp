using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02381Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02381();
        Assert.That(sut.ShiftingLetters("abc", [[0, 1, 0], [1, 2, 1], [0, 2, 1]]), Is.EqualTo("ace"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02381();
        Assert.That(sut.ShiftingLetters("dztz", [[0, 0, 0], [1, 1, 1]]), Is.EqualTo("catz"));
    }
}
