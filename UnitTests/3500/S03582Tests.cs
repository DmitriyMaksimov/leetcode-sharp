using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03582))]
public class S03582Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03582();
        Assert.That(sut.GenerateTag("Leetcode daily streak achieved"), Is.EqualTo("#leetcodeDailyStreakAchieved"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03582();
        Assert.That(sut.GenerateTag("can I Go There"), Is.EqualTo("#canIGoThere"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03582();
        Assert.That(sut.GenerateTag("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"),
            Is.EqualTo("#hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"));
    }
}