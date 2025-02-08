using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02349Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02349.NumberContainers();
        Assert.That(sut.Find(10), Is.EqualTo(-1)); // There is no index that is filled with number 10. Therefore, we return -1.
        sut.Change(2, 10); // Your container at index 2 will be filled with number 10.
        sut.Change(1, 10); // Your container at index 1 will be filled with number 10.
        sut.Change(3, 10); // Your container at index 3 will be filled with number 10.
        sut.Change(5, 10); // Your container at index 5 will be filled with number 10.
        Assert.That(sut.Find(10), Is.EqualTo(1)); // Number 10 is at the indices 1, 2, 3, and 5. Since the smallest index that is filled with 10 is 1, we return 1.
        sut.Change(1, 20); // Your container at index 1 will be filled with number 20. Note that index 1 was filled with 10 and then replaced with 20.
        Assert.That(sut.Find(10), Is.EqualTo(2)); // Number 10 is at the indices 2, 3, and 5. The smallest index that is filled with 10 is 2. Therefore, we return 2.
    }
}
