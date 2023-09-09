using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01592Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01592();
        sut.ReorderSpaces("  this   is  a sentence ").Should().Be("this   is   a   sentence");
    }

    [Test]
    public void T2()
    {
        var sut = new S01592();
        sut.ReorderSpaces(" practice   makes   perfect").Should().Be("practice   makes   perfect ");
    }
}