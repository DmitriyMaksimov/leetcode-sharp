using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01094Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01094();
        sut.CarPooling([[2, 1, 5], [3, 3, 7]], 4).Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S01094();
        sut.CarPooling([[2, 1, 5], [3, 3, 7]], 5).Should().BeTrue();
    }
}
