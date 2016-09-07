﻿using System;
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
    /// <summary>
    /// Form to enter parameters and display results of the subset sum calculator.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculate button "Click" trigger.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            var invalidInput = performCalculations(
                this.sumTextBox, 
                this.valuesTextBox, 
                this.outputTextBox);

            switch (invalidInput)
            {
                case InvalidInput.Sum:
                case InvalidInput.Values:
                    MessageBox.Show("Please fix your invalid \"" 
                        + getInvalidInputString(invalidInput) + "\" field.",
                        "Invalid " + getInvalidInputString(invalidInput));
                    break;
                case InvalidInput.NoResults:
                    MessageBox.Show("No values add together to make the sum \"" + sumTextBox.Text + "\"!");
                    break;
                case InvalidInput.None:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Calculates the subset sum by using the input TextBoxes to supply the output TextBox.
        /// </summary>
        /// <param name="sumTextBox">The "sum" input box.</param>
        /// <param name="valuesTextBox">The "values" input box.</param>
        /// <param name="outputTextBox">The "subsets" output box.</param>
        /// <returns>Returns the state of the inputs or None if there were no issues.</returns>
        private InvalidInput performCalculations(
            TextBox sumTextBox, 
            TextBox valuesTextBox, 
            TextBox outputTextBox)
        {
            decimal sum;
            decimal[] values;
            var invalidInput = InvalidInput.None;

            invalidInput = validateFields(sumTextBox.Text, valuesTextBox.Text, out sum, out values);
            if (invalidInput == InvalidInput.None)
            {
                var calc = new SubsetSumCalculator(sum, values);

                var applicableSubsets = calc.GetSubsets();

                if (applicableSubsets.Count == 0)
                {
                    invalidInput = InvalidInput.NoResults;
                }

                else
                {
                    var sApplicableSubsets = convertSubsetsWithSumToStrings(applicableSubsets);
                    var oneSApplicableSubsets = String.Join(System.Environment.NewLine, sApplicableSubsets);
                    outputTextBox.Text = oneSApplicableSubsets;
                }
            }

            return invalidInput;
        }
        
        /// <summary>
        /// Converts a list of decimal arrays to a list of comma-separated strings.
        /// </summary>
        /// <param name="allSubsetsWithSum">All subsets that sum to the target sum.</param>
        /// <returns>Returns a list of comma-separated subset strings.</returns>
        private List<string> convertSubsetsWithSumToStrings(List<decimal[]> allSubsetsWithSum)
        {
            var stringSubsets = new List<string>();

            foreach (var subset in allSubsetsWithSum)
            {
                stringSubsets.Add(String.Join(", ", subset));
            }

            return stringSubsets;
        }

        /// <summary>
        /// Validates the input fields and returns the state of invalid fields.
        /// </summary>
        /// <param name="sumText">The text of the "sum" field.</param>
        /// <param name="valuesText">The text of the "values" field.</param>
        /// <param name="outputSum">The result of parsing the "sum" field.</param>
        /// <param name="outputValues">The result of parsing the "values" field.</param>
        /// <returns>Returns an InvalidInput to describe which field was invalid.</returns>
        private InvalidInput validateFields(string sumText, string valuesText, out decimal outputSum, out decimal[] outputValues)
        {
            var invalidInput = InvalidInput.Sum;

            decimal? sum = null;
            decimal[] values = null;
            outputSum = 0;
            outputValues = new decimal[0];

            try
            {
                sum = getSum(sumText);
                invalidInput = InvalidInput.Values;

                values = getValues(valuesText);
                invalidInput = InvalidInput.None;

                outputSum = (int)sum;
                outputValues = values;
            }

            catch (Exception)
            {
                // Disregard exception; use enum to report issue
            }

            return invalidInput;
        }

        /// <summary>
        /// Parses the supplied string for a decimal sum.
        /// Throws an InvalidCastException if the parse fails.
        /// </summary>
        /// <param name="sSum">The sum as a string.</param>
        /// <returns>Returns the parsed sum.</returns>
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

        /// <summary>
        /// Parses the supplied string for a decimal array of values.
        /// Throws an InvalidCastException if the parse fails.
        /// </summary>
        /// <param name="sValues">The values as a string.</param>
        /// <returns>Returns the parsed values.</returns>
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

        /// <summary>
        /// Translates an InvalidInput to a string describing an incorrect field.
        /// </summary>
        /// <param name="invalidInput">The result of an input validation.</param>
        /// <returns>Returns a stringified InvalidInput.</returns>
        private string getInvalidInputString(InvalidInput invalidInput)
        {
            var toString = "";

            switch (invalidInput)
            {
                case InvalidInput.Sum:
                    toString = "sum";
                    break;
                case InvalidInput.Values:
                    toString = "values";
                    break;
                case InvalidInput.None:
                case InvalidInput.NoResults:
                default:
                    toString = "N/A";
                    break;
            }

            return toString;
        }

        /// <summary>
        /// The exit button's "Click" trigger.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    /// <summary>
    /// The state of the input on the form.
    /// </summary>
    public enum InvalidInput
    {
        /// <summary>
        /// Denotes the "sum" field is invalid.
        /// </summary>
        Sum, 
        /// <summary>
        /// Denotes the "values" field is invalid.
        /// </summary>
        Values, 
        /// <summary>
        /// Denotes that no "values" sum together to the "sum" field.
        /// </summary>
        NoResults,
        /// <summary>
        /// Denotes that no inputs are invalid.
        /// </summary>
        None
    }
}
