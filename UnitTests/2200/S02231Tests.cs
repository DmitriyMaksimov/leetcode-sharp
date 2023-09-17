using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02231Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02231();
        sut.LargestInteger(1234).Should().Be(3412);
    }

    [Test]
    public void T2()
    {
        var sut = new S02231();
        sut.LargestInteger(65875).Should().Be(87655);
    }
}