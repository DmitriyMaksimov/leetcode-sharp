using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01008Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01008();
        Assert.That(sut.BstFromPreorder(new[] {8,5,1,7,10,12 }).AsString(), Is.EqualTo("[8,5,10,1,7,null,12]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01008();
        Assert.That(sut.BstFromPreorder(new[] {1,3 }).AsString(), Is.EqualTo("[1,null,3]"));
    }
}