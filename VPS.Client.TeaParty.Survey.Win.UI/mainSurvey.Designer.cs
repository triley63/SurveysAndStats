namespace VPS.Client.TeaParty.Survey.Win.UI
{
    partial class mainSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainSurvey));
            this.mainSurveyToolbar = new System.Windows.Forms.ToolStrip();
            this.newSurvey = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.survey = new System.Windows.Forms.ToolStripComboBox();
            this.surveyLabel = new System.Windows.Forms.ToolStripLabel();
            this.personSection = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.add1 = new System.Windows.Forms.Label();
            this.address1 = new System.Windows.Forms.TextBox();
            this.cityName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.TextBox();
            this.mainSurveyToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSurveyToolbar
            // 
            this.mainSurveyToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSurvey,
            this.toolStripSeparator1,
            this.survey,
            this.surveyLabel});
            this.mainSurveyToolbar.Location = new System.Drawing.Point(0, 0);
            this.mainSurveyToolbar.Name = "mainSurveyToolbar";
            this.mainSurveyToolbar.Size = new System.Drawing.Size(769, 25);
            this.mainSurveyToolbar.TabIndex = 0;
            this.mainSurveyToolbar.Text = "toolStrip1";
            // 
            // newSurvey
            // 
            this.newSurvey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newSurvey.Image = ((System.Drawing.Image)(resources.GetObject("newSurvey.Image")));
            this.newSurvey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newSurvey.Name = "newSurvey";
            this.newSurvey.Size = new System.Drawing.Size(73, 22);
            this.newSurvey.Text = "New Survey";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // survey
            // 
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(121, 25);
            this.survey.Text = "Select Survey";
            this.survey.TextChanged += new System.EventHandler(this.survey_TextChanged);
            // 
            // surveyLabel
            // 
            this.surveyLabel.Name = "surveyLabel";
            this.surveyLabel.Size = new System.Drawing.Size(80, 22);
            this.surveyLabel.Text = "Survey to run.";
            // 
            // personSection
            // 
            this.personSection.AutoSize = true;
            this.personSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personSection.Location = new System.Drawing.Point(12, 42);
            this.personSection.Name = "personSection";
            this.personSection.Size = new System.Drawing.Size(151, 17);
            this.personSection.TabIndex = 1;
            this.personSection.Text = "Member Information";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Location = new System.Drawing.Point(72, 74);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(58, 13);
            this.last.TabIndex = 2;
            this.last.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(136, 71);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(217, 20);
            this.lastName.TabIndex = 0;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(421, 74);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(57, 13);
            this.first.TabIndex = 2;
            this.first.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(484, 71);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(217, 20);
            this.firstName.TabIndex = 3;
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(47, 111);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(45, 13);
            this.add1.TabIndex = 2;
            this.add1.Text = "Address";
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(94, 108);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(163, 20);
            this.address1.TabIndex = 3;
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.Location = new System.Drawing.Point(556, 126);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(24, 13);
            this.cityName.TabIndex = 2;
            this.cityName.Text = "City";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(502, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 3;
            // 
            // st
            // 
            this.st.AutoSize = true;
            this.st.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st.Location = new System.Drawing.Point(641, 126);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(32, 13);
            this.st.TabIndex = 2;
            this.st.Text = "State";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(641, 108);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(33, 20);
            this.state.TabIndex = 3;
            this.state.Text = "TN";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.Location = new System.Drawing.Point(699, 126);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(21, 13);
            this.zip.TabIndex = 2;
            this.zip.Text = "Zip";
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(680, 108);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(59, 20);
            this.zipCode.TabIndex = 3;
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(272, 111);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(45, 13);
            this.add2.TabIndex = 2;
            this.add2.Text = "Address";
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(319, 108);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(162, 20);
            this.address2.TabIndex = 3;
            // 
            // mainSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 481);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.state);
            this.Controls.Add(this.st);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.first);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.last);
            this.Controls.Add(this.personSection);
            this.Controls.Add(this.mainSurveyToolbar);
            this.Name = "mainSurvey";
            this.Text = "Survey";
            this.mainSurveyToolbar.ResumeLayout(false);
            this.mainSurveyToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainSurveyToolbar;
        private System.Windows.Forms.ToolStripButton newSurvey;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox survey;
        private System.Windows.Forms.ToolStripLabel surveyLabel;
        private System.Windows.Forms.Label personSection;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label add1;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label zip;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.TextBox address2;
    }
}

