namespace leetcode_sharp;

// 3484. Design Spreadsheet
// https://leetcode.com/problems/design-spreadsheet
public static class S03484
{
    public class Spreadsheet
    {
        private readonly Dictionary<string, int> _cells = new();

        public Spreadsheet(int rows)
        {
        }

        public void SetCell(string cell, int value)
        {
            if (value == 0)
            {
                ResetCell(cell);
            }
            else
            {
                _cells[cell] = value;
            }
        }

        public void ResetCell(string cell)
        {
            _cells.Remove(cell);
        }

        public int GetValue(string formula)
        {
            var operands = formula[1..].Split('+');
            return CalculateValue(operands[0]) + CalculateValue(operands[1]);
        }

        private int CalculateValue(string formula)
        {
            return char.IsDigit(formula[0]) ? int.Parse(formula) : _cells.GetValueOrDefault(formula);
        }
    }
}
