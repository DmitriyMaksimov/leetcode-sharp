using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01436Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01436();
        sut.DestCity(new List<IList<string>>
        {
            new List<string> {"London", "New York"},
            new List<string> {"New York", "Lima"},
            new List<string> {"Lima", "Sao Paulo"}
        }).Should().Be("Sao Paulo");
    }

    [Test]
    public void T2()
    {
        var sut = new S01436();
        sut.DestCity(new List<IList<string>>
        {
            new List<string> {"B", "C"},
            new List<string> {"D", "B"},
            new List<string> {"C", "A"}
        }).Should().Be("A");
    }

    [Test]
    public void T3()
    {
        var sut = new S01436();
        sut.DestCity(new List<IList<string>>
        {
            new List<string> {"A", "Z"}
        }).Should().Be("Z");
    }
}