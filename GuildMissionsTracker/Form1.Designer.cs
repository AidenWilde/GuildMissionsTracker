namespace GuildMissionsTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_MissionTypes = new System.Windows.Forms.GroupBox();
            this.button_ResetAllServersList = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton_LifeskillsGathering = new System.Windows.Forms.RadioButton();
            this.groupBox_ServerList = new System.Windows.Forms.GroupBox();
            this.groupBox_MissionTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_MissionTypes
            // 
            this.groupBox_MissionTypes.Controls.Add(this.button_ResetAllServersList);
            this.groupBox_MissionTypes.Controls.Add(this.radioButton2);
            this.groupBox_MissionTypes.Controls.Add(this.radioButton_LifeskillsGathering);
            this.groupBox_MissionTypes.Location = new System.Drawing.Point(1, 12);
            this.groupBox_MissionTypes.Name = "groupBox_MissionTypes";
            this.groupBox_MissionTypes.Size = new System.Drawing.Size(144, 118);
            this.groupBox_MissionTypes.TabIndex = 0;
            this.groupBox_MissionTypes.TabStop = false;
            this.groupBox_MissionTypes.Text = "Mission type";
            // 
            // button_ResetAllServersList
            // 
            this.button_ResetAllServersList.Location = new System.Drawing.Point(6, 89);
            this.button_ResetAllServersList.Name = "button_ResetAllServersList";
            this.button_ResetAllServersList.Size = new System.Drawing.Size(132, 23);
            this.button_ResetAllServersList.TabIndex = 2;
            this.button_ResetAllServersList.Text = "Reset all";
            this.button_ResetAllServersList.UseVisualStyleBackColor = true;
            this.button_ResetAllServersList.Click += new System.EventHandler(this.button_ResetAllServersList_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PvE";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton_LifeskillsGathering
            // 
            this.radioButton_LifeskillsGathering.AutoSize = true;
            this.radioButton_LifeskillsGathering.Location = new System.Drawing.Point(6, 22);
            this.radioButton_LifeskillsGathering.Name = "radioButton_LifeskillsGathering";
            this.radioButton_LifeskillsGathering.Size = new System.Drawing.Size(64, 19);
            this.radioButton_LifeskillsGathering.TabIndex = 0;
            this.radioButton_LifeskillsGathering.TabStop = true;
            this.radioButton_LifeskillsGathering.Text = "Lifeskill";
            this.radioButton_LifeskillsGathering.UseVisualStyleBackColor = false;
            // 
            // groupBox_ServerList
            // 
            this.groupBox_ServerList.Location = new System.Drawing.Point(151, 12);
            this.groupBox_ServerList.Name = "groupBox_ServerList";
            this.groupBox_ServerList.Size = new System.Drawing.Size(114, 286);
            this.groupBox_ServerList.TabIndex = 1;
            this.groupBox_ServerList.TabStop = false;
            this.groupBox_ServerList.Text = "Server list";
            this.groupBox_ServerList.Enter += new System.EventHandler(this.groupBox_ServerList_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 311);
            this.Controls.Add(this.groupBox_MissionTypes);
            this.Controls.Add(this.groupBox_ServerList);
            this.Name = "Form1";
            this.Text = "Guild Mission Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_MissionTypes.ResumeLayout(false);
            this.groupBox_MissionTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox_MissionTypes;
        private RadioButton radioButton2;
        private RadioButton radioButton_LifeskillsGathering;
        private GroupBox groupBox_ServerList;
        private Button button_ResetAllServersList;
    }
}