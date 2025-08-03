using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00922Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00922();
        var nums = sut.SortArrayByParityII([4, 2, 5, 7]);
        for (var i = 0; i < nums.Length; i++)
        {
            Assert.That((nums[i] % 2), Is.EqualTo(i % 2));
        }
    }

    [Test]
    public void T2()
    {
        var sut = new S00922();
        var nums = sut.SortArrayByParityII([2, 3]);
        for (var i = 0; i < nums.Length; i++)
        {
            Assert.That((nums[i] % 2), Is.EqualTo(i % 2));
        }
    }
}