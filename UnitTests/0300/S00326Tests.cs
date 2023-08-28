using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00326Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00326();
        sut.IsPowerOfThree(27).Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00326();
        sut.IsPowerOfThree(0).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00326();
        sut.IsPowerOfThree(-1).Should().BeFalse();
    }

}