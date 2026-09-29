using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02267))]
public class S02267Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02267();
        Assert.That(sut.HasValidPath([['(', '(', '('], [')', '(', ')'], ['(', '(', ')'], ['(', '(', ')']]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02267();
        Assert.That(sut.HasValidPath([[')', ')'], ['(', '(']]), Is.False);
    }
}