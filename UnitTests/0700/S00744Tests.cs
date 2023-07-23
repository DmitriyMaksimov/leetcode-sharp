using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00744Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00744();
        sut.NextGreatestLetter(new[] {'c', 'f', 'j'}, 'a').Should().Be('c');
    }

    [Test]
    public void T2()
    {
        var sut = new S00744();
        sut.NextGreatestLetter(new[] {'c', 'f', 'j'}, 'c').Should().Be('f');
    }

    [Test]
    public void T3()
    {
        var sut = new S00744();
        sut.NextGreatestLetter(new[] {'x', 'x', 'y', 'y'}, 'z').Should().Be('x');
    }
}