using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00942Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00942();
        sut.DiStringMatch("IDID").Should().Equal(0, 4, 1, 3, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00942();
        sut.DiStringMatch("III").Should().Equal(0, 1, 2, 3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00942();
        sut.DiStringMatch("DDI").Should().Equal(3, 2, 0, 1);
    }
}