namespace BasicFacebookFeatures
{
    internal partial class FormComposerSpecificDate
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
            this.dateTimePickerDesired = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCreatedAlbums = new System.Windows.Forms.CheckBox();
            this.checkBoxCreatedPosts = new System.Windows.Forms.CheckBox();
            this.buttonSpecificDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDesired
            // 
            this.dateTimePickerDesired.Location = new System.Drawing.Point(217, 9);
            this.dateTimePickerDesired.Name = "dateTimePickerDesired";
            this.dateTimePickerDesired.Size = new System.Drawing.Size(272, 22);
            this.dateTimePickerDesired.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Desired Date:";
            // 
            // checkBoxCreatedAlbums
            // 
            this.checkBoxCreatedAlbums.AutoSize = true;
            this.checkBoxCreatedAlbums.Location = new System.Drawing.Point(114, 75);
            this.checkBoxCreatedAlbums.Name = "checkBoxCreatedAlbums";
            this.checkBoxCreatedAlbums.Size = new System.Drawing.Size(130, 21);
            this.checkBoxCreatedAlbums.TabIndex = 4;
            this.checkBoxCreatedAlbums.Text = "Created Albums";
            this.checkBoxCreatedAlbums.UseVisualStyleBackColor = true;
            this.checkBoxCreatedAlbums.CheckedChanged += new System.EventHandler(this.checkBoxCreatedAlbums_CheckedChanged);
            // 
            // checkBoxCreatedPosts
            // 
            this.checkBoxCreatedPosts.AutoSize = true;
            this.checkBoxCreatedPosts.Location = new System.Drawing.Point(277, 75);
            this.checkBoxCreatedPosts.Name = "checkBoxCreatedPosts";
            this.checkBoxCreatedPosts.Size = new System.Drawing.Size(119, 21);
            this.checkBoxCreatedPosts.TabIndex = 5;
            this.checkBoxCreatedPosts.Text = "Created Posts";
            this.checkBoxCreatedPosts.UseVisualStyleBackColor = true;
            this.checkBoxCreatedPosts.CheckedChanged += new System.EventHandler(this.checkBoxCreatedPosts_CheckedChanged);
            // 
            // buttonSpecificDate
            // 
            this.buttonSpecificDate.Location = new System.Drawing.Point(202, 140);
            this.buttonSpecificDate.Name = "buttonSpecificDate";
            this.buttonSpecificDate.Size = new System.Drawing.Size(75, 23);
            this.buttonSpecificDate.TabIndex = 6;
            this.buttonSpecificDate.Text = "Ok";
            this.buttonSpecificDate.UseVisualStyleBackColor = true;
            this.buttonSpecificDate.Click += new System.EventHandler(this.buttonSpecificDate_Click);
            // 
            // FormComposerSpecificDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 195);
            this.Controls.Add(this.buttonSpecificDate);
            this.Controls.Add(this.checkBoxCreatedPosts);
            this.Controls.Add(this.checkBoxCreatedAlbums);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDesired);
            this.Name = "FormComposerSpecificDate";
            this.Text = "FormComposerSpecificDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDesired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCreatedAlbums;
        private System.Windows.Forms.CheckBox checkBoxCreatedPosts;
        private System.Windows.Forms.Button buttonSpecificDate;
    }
}