using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03038Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03038();
        Assert.That(sut.MaxOperations([3, 2, 1, 4, 5]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03038();
        Assert.That(sut.MaxOperations([3, 2, 6, 1, 4]), Is.EqualTo(1));
    }
}