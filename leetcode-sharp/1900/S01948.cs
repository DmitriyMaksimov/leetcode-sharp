namespace leetcode_sharp;

// 1948. Delete Duplicate Folders in System
// https://leetcode.com/problems/delete-duplicate-folders-in-system
public class S01948
{
    private sealed class Folder(string name)
    {
        public string Name { get; } = name;
        public Dictionary<string, Folder> Map { get; } = [];
        public List<Folder> List { get; } = [];
        public string Key { get; set; } = string.Empty;
        public bool Del { get; set; }
    }

    private readonly Folder _root = new("");
    private readonly Dictionary<string, int> _keys = new();

    public IList<IList<string>> DeleteDuplicateFolder(IList<IList<string>> paths)
    {
        foreach (var path in paths)
        {
            AddPath(path);
        }

        foreach (var folder in _root.List)
        {
            GenerateKey(folder);
        }

        foreach (var folder in _root.List)
        {
            UpdateDeleteStatus(folder);
        }

        var results = new List<IList<string>>();

        foreach (var path in paths)
        {
            if (IsValid(path))
                results.Add(path);
        }

        return results;
    }

    private bool IsValid(IList<string> path)
    {
        var current = _root;

        foreach (var name in path)
        {
            current = current.Map[name];
            if (current.Del)
                return false;
        }

        return true;
    }

    private void UpdateDeleteStatus(Folder folder)
    {
        if (folder.List.Count > 0 && _keys.TryGetValue(folder.Key, out var count) && count > 1)
        {
            folder.Del = true;
            return;
        }

        foreach (var child in folder.List)
        {
            UpdateDeleteStatus(child);
        }
    }

    private string GenerateKey(Folder folder)
    {
        if (folder.List.Count == 0)
            return string.Empty;

        folder.List.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));

        var key = string.Join("", folder.List.Select(child =>
            $"({child.Name}{GenerateKey(child)})"));

        folder.Key = key;
        _keys[key] = _keys.GetValueOrDefault(key, 0) + 1;

        return key;
    }

    private void AddPath(IList<string> path)
    {
        var current = _root;

        foreach (var name in path)
        {
            if (!current.Map.ContainsKey(name))
            {
                var newFolder = new Folder(name);
                current.Map[name] = newFolder;
                current.List.Add(newFolder);
            }

            current = current.Map[name];
        }
    }
}