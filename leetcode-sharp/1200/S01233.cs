namespace leetcode_sharp;

// 1233. Remove Sub-Folders from the Filesystem
// https://leetcode.com/problems/remove-sub-folders-from-the-filesystem
public class S01233
{
	public IList<string> RemoveSubfolders(string[] folder)
	{
		List<string> result = [];

		foreach (var dir in folder.Order())
		{
			if (result.Count == 0 || !dir.StartsWith(result[^1] + "/"))
			{
				result.Add(dir);
			}
		}

		return result;
	}
}
