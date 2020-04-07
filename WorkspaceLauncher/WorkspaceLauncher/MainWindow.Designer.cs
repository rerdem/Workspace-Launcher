namespace WorkspaceLauncher
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new System.Windows.Forms.ToolStrip();
            this.AddApplicationButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewWorkspaceButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteCurrentWorkspaceButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CurrentWorkspaceLabel = new System.Windows.Forms.ToolStripLabel();
            this.WorkspaceComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LaunchButton = new System.Windows.Forms.ToolStripButton();
            this.AppListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentWorkspaceNameBox = new System.Windows.Forms.TextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddApplicationButton,
            this.toolStripSeparator1,
            this.NewWorkspaceButton,
            this.DeleteCurrentWorkspaceButton,
            this.toolStripSeparator2,
            this.CurrentWorkspaceLabel,
            this.WorkspaceComboBox,
            this.toolStripSeparator3,
            this.LaunchButton});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(794, 38);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // AddApplicationButton
            // 
            this.AddApplicationButton.Image = ((System.Drawing.Image)(resources.GetObject("AddApplicationButton.Image")));
            this.AddApplicationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddApplicationButton.Name = "AddApplicationButton";
            this.AddApplicationButton.Size = new System.Drawing.Size(97, 35);
            this.AddApplicationButton.Text = "Add Application";
            this.AddApplicationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddApplicationButton.Click += new System.EventHandler(this.AddApplicationButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // NewWorkspaceButton
            // 
            this.NewWorkspaceButton.Image = ((System.Drawing.Image)(resources.GetObject("NewWorkspaceButton.Image")));
            this.NewWorkspaceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewWorkspaceButton.Name = "NewWorkspaceButton";
            this.NewWorkspaceButton.Size = new System.Drawing.Size(133, 35);
            this.NewWorkspaceButton.Text = "Create New Workspace";
            this.NewWorkspaceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewWorkspaceButton.Click += new System.EventHandler(this.NewWorkspaceButton_Click);
            // 
            // DeleteCurrentWorkspaceButton
            // 
            this.DeleteCurrentWorkspaceButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCurrentWorkspaceButton.Image")));
            this.DeleteCurrentWorkspaceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCurrentWorkspaceButton.Name = "DeleteCurrentWorkspaceButton";
            this.DeleteCurrentWorkspaceButton.Size = new System.Drawing.Size(148, 35);
            this.DeleteCurrentWorkspaceButton.Text = "Delete Current Workspace";
            this.DeleteCurrentWorkspaceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCurrentWorkspaceButton.Click += new System.EventHandler(this.DeleteCurrentWorkspaceButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // CurrentWorkspaceLabel
            // 
            this.CurrentWorkspaceLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CurrentWorkspaceLabel.Name = "CurrentWorkspaceLabel";
            this.CurrentWorkspaceLabel.Size = new System.Drawing.Size(111, 35);
            this.CurrentWorkspaceLabel.Text = "Current Workspace:";
            // 
            // WorkspaceComboBox
            // 
            this.WorkspaceComboBox.AutoSize = false;
            this.WorkspaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkspaceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.WorkspaceComboBox.Name = "WorkspaceComboBox";
            this.WorkspaceComboBox.Size = new System.Drawing.Size(200, 23);
            this.WorkspaceComboBox.SelectedIndexChanged += new System.EventHandler(this.WorkspaceComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // LaunchButton
            // 
            this.LaunchButton.AutoToolTip = false;
            this.LaunchButton.Image = ((System.Drawing.Image)(resources.GetObject("LaunchButton.Image")));
            this.LaunchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(67, 35);
            this.LaunchButton.Text = "Launch All";
            this.LaunchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LaunchButton.ToolTipText = "Launch All Applications in Current Workspace";
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // AppListPanel
            // 
            this.AppListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppListPanel.Location = new System.Drawing.Point(0, 77);
            this.AppListPanel.Name = "AppListPanel";
            this.AppListPanel.Size = new System.Drawing.Size(794, 372);
            this.AppListPanel.TabIndex = 3;
            // 
            // CurrentWorkspaceNameBox
            // 
            this.CurrentWorkspaceNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentWorkspaceNameBox.Location = new System.Drawing.Point(12, 42);
            this.CurrentWorkspaceNameBox.Name = "CurrentWorkspaceNameBox";
            this.CurrentWorkspaceNameBox.Size = new System.Drawing.Size(469, 29);
            this.CurrentWorkspaceNameBox.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 461);
            this.Controls.Add(this.CurrentWorkspaceNameBox);
            this.Controls.Add(this.AppListPanel);
            this.Controls.Add(this.MainMenu);
            this.Name = "MainWindow";
            this.Text = "Workspace Launcher";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainMenu;
        private System.Windows.Forms.ToolStripButton AddApplicationButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NewWorkspaceButton;
        private System.Windows.Forms.ToolStripButton DeleteCurrentWorkspaceButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton LaunchButton;
        private System.Windows.Forms.FlowLayoutPanel AppListPanel;
        private System.Windows.Forms.TextBox CurrentWorkspaceNameBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel CurrentWorkspaceLabel;
        private System.Windows.Forms.ToolStripComboBox WorkspaceComboBox;
    }
}

