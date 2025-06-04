using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03403))]
public class S03403Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03403();
        Assert.That(sut.AnswerString("dbca", 2), Is.EqualTo("dbc"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03403();
        Assert.That(sut.AnswerString("gggg", 4), Is.EqualTo("g"));
    }
}
