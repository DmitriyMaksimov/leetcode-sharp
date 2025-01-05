using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02381Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02381();
        sut.ShiftingLetters("abc", [[0, 1, 0], [1, 2, 1], [0, 2, 1]]).Should().Be("ace");
    }

    [Test]
    public void T2()
    {
        var sut = new S02381();
        sut.ShiftingLetters("dztz", [[0, 0, 0], [1, 1, 1]]).Should().Be("catz");
    }
}
