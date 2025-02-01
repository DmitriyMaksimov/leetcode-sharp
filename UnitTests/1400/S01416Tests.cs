using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01416Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01416();
        Assert.That(sut.NumberOfArrays("1000", 10000), Is.EqualTo(1));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01416();
        Assert.That(sut.NumberOfArrays("1000", 10), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01416();
        Assert.That(sut.NumberOfArrays("1317", 2000), Is.EqualTo(8));
    }

    [Test]
    public void T4()
    {
        var sut = new S01416();
        Assert.That(sut.NumberOfArrays("407780786171321121429620765476840275495357129574174233567552131453038760763182952432348422252546559691171161181440370120987634895458140447952079749439961325982629462531738374032416182281868731817661954890417245087359968833257550123324827240537957646002494771036413572415", 823924906), Is.EqualTo(427125123));
    }
}