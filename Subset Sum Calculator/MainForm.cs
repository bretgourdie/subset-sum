using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Subset_Sum_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal sum;
            decimal[] values;

            var result = validateFields(sumTextBox.Text, valuesTextBox.Text, out sum, out values);
            if (result == InvalidField.None)
            {
                var calc = new SubsetSumCalculator(sum, values);

                var applicableSubsets = calc.GetMatches();

                if (applicableSubsets.Count == 0)
                {
                    MessageBox.Show("No values add together to make the sum \"" + sum.ToString() + "\"!");
                }

                else
                {
                    var sApplicableSubsets = String.Join(System.Environment.NewLine, applicableSubsets);
                    outputTextBox.Text = sApplicableSubsets;
                }
            }

            else
            {
                MessageBox.Show("Please fix your invalid \"" + getInvalidFieldString(result) + "\" field.",
                    "Invalid " + result.ToString());
            }
        }

        private InvalidField validateFields(string sumText, string valuesText, out decimal outputSum, out decimal[] outputValues)
        {
            var invalidField = InvalidField.Sum;

            decimal? sum = null;
            decimal[] values = null;
            outputSum = 0;
            outputValues = new decimal[0];

            try
            {
                sum = getSum(sumText);
                invalidField = InvalidField.Values;

                values = getValues(valuesText);
                invalidField = InvalidField.None;

                outputSum = (int)sum;
                outputValues = values;
            }

            catch (Exception)
            {
                // Disregard exception; use enum to report issue
            }

            return invalidField;
        }

        private decimal getSum(string sSum)
        {
            decimal sum;

            try
            {
                sum = Decimal.Parse(sSum);
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }

            return sum;
        }

        private decimal[] getValues(string sValues)
        {
            var emptyCharArray = new char[0];
            var stringSplit = sValues.Split(emptyCharArray, StringSplitOptions.RemoveEmptyEntries);

            var listOfDecimals = new List<decimal>();

            try
            {
                foreach (var singleNumber in stringSplit)
                {
                    var parseResult = Decimal.Parse(singleNumber);

                    listOfDecimals.Add(parseResult);
                }
            }

            catch (InvalidCastException ex)
            {
                throw ex;
            }

            return listOfDecimals.ToArray();
        }

        private string getInvalidFieldString(InvalidField invalidField)
        {
            var toString = "";

            switch (invalidField)
            {
                case InvalidField.Sum:
                    toString = "sum";
                    break;
                case InvalidField.Values:
                    toString = "values";
                    break;
                case InvalidField.None:
                default:
                    toString = "N/A";
                    break;
            }

            return toString;
        }
    }

    public enum InvalidField
    {
        Sum, Values, None
    }
}
