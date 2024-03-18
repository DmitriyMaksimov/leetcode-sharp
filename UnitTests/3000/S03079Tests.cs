using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03079Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03079();
        sut.SumOfEncryptedInt([1, 2, 3]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S03079();
        sut.SumOfEncryptedInt([10, 21, 31]).Should().Be(66);
    }
}