namespace BoDemAsync
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.MaxiumNumberLabel = new System.Windows.Forms.Label();
            this.CurrentNumberLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CounterControlButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.844981F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.49932F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30499F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Controls.Add(this.instructionLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MaxiumNumberLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CurrentNumberLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CounterControlButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.UserInputTextBox, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48148F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.18519F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructionLabel.Location = new System.Drawing.Point(46, 75);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(219, 20);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Number:";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MaxiumNumberLabel
            // 
            this.MaxiumNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxiumNumberLabel.AutoSize = true;
            this.MaxiumNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MaxiumNumberLabel.Location = new System.Drawing.Point(271, 104);
            this.MaxiumNumberLabel.Name = "MaxiumNumberLabel";
            this.MaxiumNumberLabel.Size = new System.Drawing.Size(99, 20);
            this.MaxiumNumberLabel.TabIndex = 5;
            this.MaxiumNumberLabel.Text = "/0";
            this.MaxiumNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentNumberLabel
            // 
            this.CurrentNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentNumberLabel.AutoSize = true;
            this.CurrentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CurrentNumberLabel.Location = new System.Drawing.Point(46, 104);
            this.CurrentNumberLabel.Name = "CurrentNumberLabel";
            this.CurrentNumberLabel.Size = new System.Drawing.Size(219, 20);
            this.CurrentNumberLabel.TabIndex = 3;
            this.CurrentNumberLabel.Text = "0";
            this.CurrentNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 3);
            this.progressBar1.Location = new System.Drawing.Point(46, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(689, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // CounterControlButton
            // 
            this.CounterControlButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CounterControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CounterControlButton.Location = new System.Drawing.Point(376, 176);
            this.CounterControlButton.Name = "CounterControlButton";
            this.CounterControlButton.Size = new System.Drawing.Size(110, 47);
            this.CounterControlButton.TabIndex = 6;
            this.CounterControlButton.Text = "Start";
            this.CounterControlButton.UseVisualStyleBackColor = true;
            this.CounterControlButton.Click += new System.EventHandler(this.CounterControl);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResetButton.Location = new System.Drawing.Point(295, 176);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 47);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButtonClickEvent);
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.Location = new System.Drawing.Point(271, 73);
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(99, 22);
            this.UserInputTextBox.TabIndex = 8;
            this.UserInputTextBox.TextChanged += new System.EventHandler(this.TextChangedEvent);
            this.UserInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEventForTextBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(787, 270);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(805, 317);
            this.MinimumSize = new System.Drawing.Size(805, 317);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label CurrentNumberLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label MaxiumNumberLabel;
        private System.Windows.Forms.Button CounterControlButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox UserInputTextBox;
    }
}

