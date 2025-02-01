using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00118Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00118();
        var list = sut.Generate(5);
        list.Should().HaveCount(5);
        Assert.That(list[0], Is.EqualTo((int[]) [1]));
        Assert.That(list[1], Is.EqualTo((int[]) [1, 1]));
        Assert.That(list[2], Is.EqualTo((int[]) [1, 2, 1]));
        Assert.That(list[3], Is.EqualTo((int[]) [1, 3, 3, 1]));
        Assert.That(list[4], Is.EqualTo((int[]) [1, 4, 6, 4, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00118();
        var list = sut.Generate(1);
        list.Should().HaveCount(1);
        Assert.That(list[0], Is.EqualTo((int[]) [1]));
    }
}