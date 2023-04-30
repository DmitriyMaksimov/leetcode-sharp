namespace leetcode_sharp;

    public class UnionFind
    {
        int[] component;
        int distinctComponents;

        /*
         *   Initially all 'n' nodes are in different components.
         *   e.g. component[2] = 2 i.e. node 2 belong to component 2.
         */
        public UnionFind(int n)
        {
            distinctComponents = n;
            component = Enumerable.Range(0, n + 1).ToArray();
        }

        // Unite components
        // Returns true when nodes 'a' and 'b' are in different components
        public bool Unite(int a, int b)
        {
            if (FindComponent(a) == FindComponent(b))
            {
                return false;
            }

            component[FindComponent(a)] = b;
            distinctComponents--;

            return true;
        }

        // Returns component the node 'a' belong to.
        public int FindComponent(int a)
        {
            if (component[a] != a)
            {
                component[a] = FindComponent(component[a]);
            }

            return component[a];
        }

         // Are all nodes united into a single component?
        public bool United()
        {
            return distinctComponents == 1;
        }
    }