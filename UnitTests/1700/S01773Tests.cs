using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01773Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01773();
        Assert.That(sut.CountMatches(new List<IList<string>>
        {
            new List<string> {"phone", "blue", "pixel"},
            new List<string> {"computer", "silver", "lenovo"},
            new List<string> {"phone", "gold", "iphone"}
        }, "color", "silver"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01773();
        Assert.That(sut.CountMatches(new List<IList<string>>
        {
            new List<string> {"phone","blue","pixel"},
            new List<string> {"computer","silver","phone"},
            new List<string> {"phone","gold","iphone"}
        }, "type", "phone"), Is.EqualTo(2));
    }
}