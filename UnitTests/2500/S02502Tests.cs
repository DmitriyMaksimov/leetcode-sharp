using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02502Tests
{
    [Test]
    public void T1()
    {
        var allocator = new S02502.Allocator(10);
        Assert.That(allocator.Allocate(1, 1), Is.EqualTo(0)); // The leftmost block's first index is 0. The memory array becomes [1,_,_,_,_,_,_,_,_,_]. We return 0.
        Assert.That(allocator.Allocate(1, 2), Is.EqualTo(1)); // The leftmost block's first index is 1. The memory array becomes [1,2,_,_,_,_,_,_,_,_]. We return 1.
        Assert.That(allocator.Allocate(1, 3), Is.EqualTo(2)); // The leftmost block's first index is 2. The memory array becomes [1,2,3,_,_,_,_,_,_,_]. We return 2.
        Assert.That(allocator.FreeMemory(2), Is.EqualTo(1)); // Free all memory units with mID 2. The memory array becomes [1,_, 3,_,_,_,_,_,_,_]. We return 1 since there is only 1 unit with mID 2.
        Assert.That(allocator.Allocate(3, 4), Is.EqualTo(3)); // The leftmost block's first index is 3. The memory array becomes [1,_,3,4,4,4,_,_,_,_]. We return 3.
        Assert.That(allocator.Allocate(1, 1), Is.EqualTo(1)); // The leftmost block's first index is 1. The memory array becomes [1,1,3,4,4,4,_,_,_,_]. We return 1.
        Assert.That(allocator.Allocate(1, 1), Is.EqualTo(6)); // The leftmost block's first index is 6. The memory array becomes [1,1,3,4,4,4,1,_,_,_]. We return 6.
        Assert.That(allocator.FreeMemory(1), Is.EqualTo(3)); // Free all memory units with mID 1. The memory array becomes [_,_,3,4,4,4,_,_,_,_]. We return 3 since there are 3 units with mID 1.
        Assert.That(allocator.Allocate(10, 2), Is.EqualTo(-1)); // We can not find any free block with 10 consecutive free memory units, so we return -1.
        Assert.That(allocator.FreeMemory(7), Is.EqualTo(0)); // Free all memory units with mID 7. The memory array remains the same since there is no memory unit with mID 7. We return 0.
    }
}
