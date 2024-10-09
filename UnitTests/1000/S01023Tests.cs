using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01023Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01023();
        sut.CamelMatch(["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"], "FB").Should().Equal(true, false, true, true, false);
    }

    [Test]
    public void T2()
    {
        var sut = new S01023();
        sut.CamelMatch(["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"], "FoBa").Should().Equal(true, false, true, false, false);
    }

    [Test]
    public void T3()
    {
        var sut = new S01023();
        sut.CamelMatch(["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"], "FoBaT").Should().Equal(false, true, false, false, false);
    }
}
