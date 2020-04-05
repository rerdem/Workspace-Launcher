namespace WorkspaceLauncher
{
    partial class ApplicationEntryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ParameterLabel = new System.Windows.Forms.Label();
            this.ParameterBox = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.PathPanel = new System.Windows.Forms.Panel();
            this.PathButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PathValueLabel = new System.Windows.Forms.Label();
            this.PathToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TablePanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.PathPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel
            // 
            this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel.ColumnCount = 3;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TablePanel.Controls.Add(this.NameLabel, 0, 0);
            this.TablePanel.Controls.Add(this.PathLabel, 1, 0);
            this.TablePanel.Controls.Add(this.ParameterLabel, 2, 0);
            this.TablePanel.Controls.Add(this.ParameterBox, 2, 1);
            this.TablePanel.Controls.Add(this.ButtonPanel, 0, 2);
            this.TablePanel.Controls.Add(this.PathPanel, 1, 1);
            this.TablePanel.Controls.Add(this.NameBox, 0, 1);
            this.TablePanel.Location = new System.Drawing.Point(3, 3);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 3;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanel.Size = new System.Drawing.Size(711, 97);
            this.TablePanel.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(239, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(33, 13);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Path";
            // 
            // ParameterLabel
            // 
            this.ParameterLabel.AutoSize = true;
            this.ParameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParameterLabel.Location = new System.Drawing.Point(476, 0);
            this.ParameterLabel.Name = "ParameterLabel";
            this.ParameterLabel.Size = new System.Drawing.Size(70, 13);
            this.ParameterLabel.TabIndex = 2;
            this.ParameterLabel.Text = "Parameters";
            // 
            // ParameterBox
            // 
            this.ParameterBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ParameterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParameterBox.Location = new System.Drawing.Point(476, 23);
            this.ParameterBox.Name = "ParameterBox";
            this.ParameterBox.Size = new System.Drawing.Size(232, 26);
            this.ParameterBox.TabIndex = 5;
            // 
            // ButtonPanel
            // 
            this.TablePanel.SetColumnSpan(this.ButtonPanel, 3);
            this.ButtonPanel.Controls.Add(this.LaunchButton);
            this.ButtonPanel.Controls.Add(this.DeleteButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonPanel.Location = new System.Drawing.Point(3, 65);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(705, 29);
            this.ButtonPanel.TabIndex = 6;
            this.ButtonPanel.WrapContents = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(478, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete Entry";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LaunchButton
            // 
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.Location = new System.Drawing.Point(559, 3);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(143, 23);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Launch Application";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // PathPanel
            // 
            this.PathPanel.Controls.Add(this.PathValueLabel);
            this.PathPanel.Controls.Add(this.PathButton);
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanel.Location = new System.Drawing.Point(239, 23);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(231, 36);
            this.PathPanel.TabIndex = 7;
            // 
            // PathButton
            // 
            this.PathButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PathButton.Location = new System.Drawing.Point(205, 0);
            this.PathButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.PathButton.MaximumSize = new System.Drawing.Size(36, 26);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(26, 26);
            this.PathButton.TabIndex = 1;
            this.PathButton.Text = "...";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(3, 23);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(230, 26);
            this.NameBox.TabIndex = 3;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.TablePanel);
            this.MainPanel.Location = new System.Drawing.Point(4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(720, 107);
            this.MainPanel.TabIndex = 1;
            // 
            // PathValueLabel
            // 
            this.PathValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathValueLabel.AutoEllipsis = true;
            this.PathValueLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PathValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathValueLabel.Location = new System.Drawing.Point(0, 0);
            this.PathValueLabel.Name = "PathValueLabel";
            this.PathValueLabel.Size = new System.Drawing.Size(202, 26);
            this.PathValueLabel.TabIndex = 2;
            this.PathValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ApplicationEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "ApplicationEntryControl";
            this.Size = new System.Drawing.Size(728, 114);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.PathPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label ParameterLabel;
        private System.Windows.Forms.TextBox ParameterBox;
        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Panel PathPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label PathValueLabel;
        private System.Windows.Forms.ToolTip PathToolTip;
    }
}
