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
            int sum;
            int[] values;

            var result = validateFields(sumTextBox.Text, valuesTextBox.Text, out sum, out values);
            if (result == InvalidField.None)
            {
                var calc = new SubsetSumCalculator(sum, values);
            }

            else
            {

            }
        }

        private InvalidField validateFields(string sumText, string valuesText, out int outputSum, out int[] outputValues)
        {
            var invalidField = InvalidField.None;

            int? sum = null;
            int[] values = null;
            outputSum = 0;
            outputValues = new int[0];

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

        private int getSum(string sSum)
        {
            int sum;

            try
            {
                sum = int.Parse(sSum);
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }

            return sum;
        }

        private int[] getValues(string sValues)
        {
            var regexSplit = Regex.Split(sValues, @"\w+");
            var listOfInts = new List<int>();

            try
            {
                foreach (var singleNumber in regexSplit)
                {
                    var parseResult = int.Parse(singleNumber);

                    listOfInts.Add(parseResult);
                }
            }

            catch (InvalidCastException ex)
            {
                throw ex;
            }

            return listOfInts.ToArray();
        }
    }

    public enum InvalidField
    {
        Sum, Values, None
    }
}
