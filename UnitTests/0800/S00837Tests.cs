using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00837Tests
{
    private const double Precision = 0.00001;

    [Test]
    public void T1()
    {
        var sut = new S00837();
        sut.New21Game(10, 1, 10).Should().BeApproximately(1, Precision);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00837();
        sut.New21Game(6, 1, 10).Should().BeApproximately(0.6, Precision);
    }

    [Test]
    public void T3()
    {
        var sut = new S00837();
        sut.New21Game(21, 17, 10).Should().BeApproximately(0.73278, Precision);
    }
}