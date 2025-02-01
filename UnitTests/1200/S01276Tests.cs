using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01276Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01276();
        sut.NumOfBurgers(16, 7).Should().Equal(1, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01276();
        Assert.That(sut.NumOfBurgers(17, 4), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S01276();
        Assert.That(sut.NumOfBurgers(4, 17), Is.Empty);
    }
}
