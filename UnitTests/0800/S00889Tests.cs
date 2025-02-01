using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00889Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00889();
        Assert.That(sut.ConstructFromPrePost([1, 2, 4, 5, 3, 6, 7], [4, 5, 2, 6, 7, 3, 1]).AsString(), Is.EqualTo("[1,2,3,4,5,6,7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00889();
        Assert.That(sut.ConstructFromPrePost([1], [1]).AsString(), Is.EqualTo("[1]"));
    }
}