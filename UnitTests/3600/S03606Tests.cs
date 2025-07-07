using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03606))]
public class S03606Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03606();
        Assert.That(sut.ValidateCoupons(
                ["SAVE20", "", "PHARMA5", "SAVE@20"],
                ["restaurant", "grocery", "pharmacy", "restaurant"],
                [true, true, true, true]),
            Is.EqualTo(["PHARMA5", "SAVE20"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03606();
        Assert.That(sut.ValidateCoupons(
                ["GROCERY15", "ELECTRONICS_50", "DISCOUNT10"],
                ["grocery", "electronics", "invalid"],
                [false, true, true]),
            Is.EqualTo(["ELECTRONICS_50"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03606();
        Assert.That(sut.ValidateCoupons(
                ["MI", "b_"],
                ["pharmacy", "pharmacy"],
                [true, true]),
            Is.EqualTo(["MI", "b_"]));
    }
}