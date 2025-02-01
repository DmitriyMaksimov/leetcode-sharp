using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03285Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03285();
        sut.StableMountains([1, 2, 3, 4, 5], 2).Should().Equal(3, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03285();
        sut.StableMountains([10, 1, 10, 1, 10], 3).Should().Equal(1, 3);
    }

    [Test]
    public void T3()
    {
        var sut = new S03285();
        Assert.That(sut.StableMountains([10, 1, 10, 1, 10], 10), Is.Empty);
    }
}
