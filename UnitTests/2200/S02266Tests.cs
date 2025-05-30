using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02266))]
public class S02266Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02266();
        Assert.That(sut.CountTexts("22233"), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02266();
        Assert.That(sut.CountTexts("222222222222222222222222222222222222"), Is.EqualTo(82876089));
    }
}
