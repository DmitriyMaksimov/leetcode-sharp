using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00200Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00200();
        Assert.That(sut.NumIslands([
            ['1', '1', '1', '1', '0'],
            ['1', '1', '0', '1', '0'],
            ['1', '1', '0', '0', '0'],
            ['0', '0', '0', '0', '0']
        ]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00200();
        Assert.That(sut.NumIslands([
            ['1','1','0','0','0'],
            ['1','1','0','0','0'],
            ['0','0','1','0','0'],
            ['0','0','0','1','1']
        ]), Is.EqualTo(3));
    }
}