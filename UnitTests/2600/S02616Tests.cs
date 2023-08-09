using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02616Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02616();
        sut.MinimizeMax(new[] {10, 1, 2, 7, 1, 3}, 2).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02616();
        sut.MinimizeMax(new[] {4, 2, 1, 2}, 1).Should().Be(0);
    }
}