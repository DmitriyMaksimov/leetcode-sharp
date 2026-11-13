using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03420))]
public class S03420Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03420();
        Assert.That(sut.CountNonDecreasingSubarrays([6, 3, 1, 2, 4, 4], 7), Is.EqualTo(17));
    }

    [Test]
    public void T2()
    {
        var sut = new S03420();
        Assert.That(sut.CountNonDecreasingSubarrays([6, 3, 1, 3, 6], 4), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S03420();
        Assert.That(sut.CountNonDecreasingSubarrays([1000000000, 1, 1, 1, 1], 1000000000), Is.EqualTo(12));
    }

    [Test]
    public void T4()
    {
        var sut = new S03420();
        Assert.That(
            sut.CountNonDecreasingSubarrays(
            [
                233212036, 446641438, 944201451, 452609353, 986441700, 251364382, 386614375, 974488234, 244867100, 76797470, 183775112, 872328366, 423047838, 410995921, 85352335,
                267594794, 30827501, 263546441, 427289866, 211309956, 802336862, 140968168, 143808019, 270779841, 280033677, 332963513, 790742590, 488872440, 748887931, 569850726,
                10064284, 359547496, 604972561, 970375618, 161483886, 611415148, 530917238, 168414924, 795462804, 546894674, 769465657, 533755349, 13521351, 669610810, 978459365,
                154682490
            ], 254039511), Is.EqualTo(113));
    }
}