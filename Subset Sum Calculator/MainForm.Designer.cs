namespace Subset_Sum_Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.programTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.valuesLabel = new System.Windows.Forms.Label();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.outputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputHeaderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputLabel = new System.Windows.Forms.Label();
            this.commasCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.programTableLayoutPanel.SuspendLayout();
            this.inputTableLayoutPanel.SuspendLayout();
            this.outputTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.outputHeaderTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.titleLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.programTableLayoutPanel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(457, 472);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(451, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Subset Sum Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programTableLayoutPanel
            // 
            this.programTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.programTableLayoutPanel.Controls.Add(this.inputTableLayoutPanel);
            this.programTableLayoutPanel.Controls.Add(this.outputTableLayoutPanel);
            this.programTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel);
            this.programTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programTableLayoutPanel.Location = new System.Drawing.Point(3, 48);
            this.programTableLayoutPanel.Name = "programTableLayoutPanel";
            this.programTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.programTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.programTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.programTableLayoutPanel.Size = new System.Drawing.Size(451, 421);
            this.programTableLayoutPanel.TabIndex = 1;
            // 
            // inputTableLayoutPanel
            // 
            this.inputTableLayoutPanel.ColumnCount = 2;
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTableLayoutPanel.Controls.Add(this.sumLabel, 0, 0);
            this.inputTableLayoutPanel.Controls.Add(this.sumTextBox, 1, 0);
            this.inputTableLayoutPanel.Controls.Add(this.valuesLabel, 0, 1);
            this.inputTableLayoutPanel.Controls.Add(this.valuesTextBox, 1, 1);
            this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            this.inputTableLayoutPanel.RowCount = 2;
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTableLayoutPanel.Size = new System.Drawing.Size(445, 140);
            this.inputTableLayoutPanel.TabIndex = 0;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sumLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLabel.Location = new System.Drawing.Point(3, 0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(51, 26);
            this.sumLabel.TabIndex = 0;
            this.sumLabel.Text = "Sum:";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sumTextBox.Location = new System.Drawing.Point(60, 3);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(181, 20);
            this.sumTextBox.TabIndex = 1;
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesLabel.Location = new System.Drawing.Point(3, 26);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(51, 114);
            this.valuesLabel.TabIndex = 2;
            this.valuesLabel.Text = "Values:";
            this.valuesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesTextBox.Location = new System.Drawing.Point(60, 29);
            this.valuesTextBox.Multiline = true;
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.valuesTextBox.Size = new System.Drawing.Size(382, 108);
            this.valuesTextBox.TabIndex = 3;
            // 
            // outputTableLayoutPanel
            // 
            this.outputTableLayoutPanel.ColumnCount = 1;
            this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputTableLayoutPanel.Controls.Add(this.outputTextBox, 0, 1);
            this.outputTableLayoutPanel.Controls.Add(this.outputHeaderTableLayoutPanel, 0, 0);
            this.outputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTableLayoutPanel.Location = new System.Drawing.Point(3, 149);
            this.outputTableLayoutPanel.Name = "outputTableLayoutPanel";
            this.outputTableLayoutPanel.RowCount = 2;
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputTableLayoutPanel.Size = new System.Drawing.Size(445, 230);
            this.outputTableLayoutPanel.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(3, 23);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(439, 204);
            this.outputTextBox.TabIndex = 1;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsTableLayoutPanel.Controls.Add(this.calculateButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.exitButton, 2, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 385);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(445, 33);
            this.buttonsTableLayoutPanel.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateButton.Location = new System.Drawing.Point(3, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(83, 27);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Location = new System.Drawing.Point(359, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 27);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputHeaderTableLayoutPanel
            // 
            this.outputHeaderTableLayoutPanel.ColumnCount = 2;
            this.outputHeaderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputHeaderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputHeaderTableLayoutPanel.Controls.Add(this.outputLabel, 0, 0);
            this.outputHeaderTableLayoutPanel.Controls.Add(this.commasCheckBox, 1, 0);
            this.outputHeaderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputHeaderTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.outputHeaderTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.outputHeaderTableLayoutPanel.Name = "outputHeaderTableLayoutPanel";
            this.outputHeaderTableLayoutPanel.RowCount = 1;
            this.outputHeaderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputHeaderTableLayoutPanel.Size = new System.Drawing.Size(445, 20);
            this.outputHeaderTableLayoutPanel.TabIndex = 2;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(3, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(216, 20);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Results";
            // 
            // commasCheckBox
            // 
            this.commasCheckBox.AutoSize = true;
            this.commasCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commasCheckBox.Location = new System.Drawing.Point(222, 0);
            this.commasCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.commasCheckBox.Name = "commasCheckBox";
            this.commasCheckBox.Size = new System.Drawing.Size(223, 20);
            this.commasCheckBox.TabIndex = 2;
            this.commasCheckBox.Text = "Add commas between subsets";
            this.commasCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 472);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Subset Sum Calculator";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.programTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.PerformLayout();
            this.outputTableLayoutPanel.ResumeLayout(false);
            this.outputTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.outputHeaderTableLayoutPanel.ResumeLayout(false);
            this.outputHeaderTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel programTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label valuesLabel;
        private System.Windows.Forms.TextBox valuesTextBox;
        private System.Windows.Forms.TableLayoutPanel outputTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TableLayoutPanel outputHeaderTableLayoutPanel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.CheckBox commasCheckBox;
    }
}

