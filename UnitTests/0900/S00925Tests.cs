using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00925Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00925();
        sut.IsLongPressedName("alex", "aaleex").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00925();
        sut.IsLongPressedName("saeed", "ssaaedd").Should().BeFalse();
    }
}