using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01023Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01023();
        Assert.That(sut.CamelMatch(["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"], "FB"), Is.EqualTo((bool[]) [true, false, true, true, false]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01023();
        Assert.That(sut.CamelMatch(["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"], "FoBa"), Is.EqualTo((bool[]) [true, false, true, false, false]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01023();
        Assert.That(sut.CamelMatch(["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"], "FoBaT"), Is.EqualTo((bool[]) [false, true, false, false, false]));
    }
}
