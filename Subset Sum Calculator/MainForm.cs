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
                    outputDataGridView.DataSource = applicableSubsets;
                }
            }

            else
            {

            }
        }

        private InvalidField validateFields(string sumText, string valuesText, out decimal outputSum, out decimal[] outputValues)
        {
            var invalidField = InvalidField.None;

            decimal? sum = null;
            decimal[] values = null;
            outputSum = 0;
            outputValues = new decimal[0];

            try
            {
                sum = getSum(sumText);
                values = getValues(valuesText);

                outputSum = (int)sum;
                outputValues = values;
            }

            catch (InvalidCastException ex)
            {
                if (sum == null)
                {
                    invalidField = InvalidField.Sum;
                }
                else if (values == null)
                {
                    invalidField = InvalidField.Values;
                }

                else
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace.ToString(), 
                        "InvlaidCastException Error");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace.ToString(), 
                    "Exception Error");
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
            var regexSplit = Regex.Split(sValues, @"\s+");
            var listOfDecimals = new List<decimal>();

            try
            {
                foreach (var singleNumber in regexSplit)
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
    }

    public enum InvalidField
    {
        Sum, Values, None
    }
}
