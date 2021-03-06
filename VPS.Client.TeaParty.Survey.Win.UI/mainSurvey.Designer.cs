﻿namespace VPS.Client.TeaParty.Survey.Win.UI
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
            this.survey = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.startSurvey = new System.Windows.Forms.ToolStripButton();
            this.personSection = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.add1 = new System.Windows.Forms.Label();
            this.address1 = new System.Windows.Forms.TextBox();
            this.cityName = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.nextPerson = new System.Windows.Forms.Button();
            this.previousPerson = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.noAnswer = new System.Windows.Forms.Button();
            this.mainSurveyToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSurveyToolbar
            // 
            this.mainSurveyToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.survey,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.groupFilter,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.startSurvey});
            this.mainSurveyToolbar.Location = new System.Drawing.Point(0, 0);
            this.mainSurveyToolbar.Name = "mainSurveyToolbar";
            this.mainSurveyToolbar.Size = new System.Drawing.Size(769, 25);
            this.mainSurveyToolbar.TabIndex = 0;
            this.mainSurveyToolbar.Text = "toolStrip1";
            // 
            // survey
            // 
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(121, 25);
            this.survey.Text = "Select Survey";
            this.survey.TextChanged += new System.EventHandler(this.survey_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel1.Text = "Filter Survey Group";
            // 
            // groupFilter
            // 
            this.groupFilter.Items.AddRange(new object[] {
            "Uncalled",
            "NoAnswer",
            "Called",
            "All"});
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // startSurvey
            // 
            this.startSurvey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startSurvey.Image = ((System.Drawing.Image)(resources.GetObject("startSurvey.Image")));
            this.startSurvey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startSurvey.Name = "startSurvey";
            this.startSurvey.Size = new System.Drawing.Size(73, 22);
            this.startSurvey.Text = "&Start Survey";
            this.startSurvey.Click += new System.EventHandler(this.startSurvey_Click);
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
            this.last.Size = new System.Drawing.Size(57, 13);
            this.last.TabIndex = 0;
            this.last.Text = "&First Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(136, 71);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(217, 20);
            this.lastName.TabIndex = 1;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(421, 74);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(58, 13);
            this.first.TabIndex = 2;
            this.first.Text = "&Last Name";
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
            this.add1.TabIndex = 4;
            this.add1.Text = "&Address";
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(94, 108);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(163, 20);
            this.address1.TabIndex = 5;
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.Location = new System.Drawing.Point(556, 126);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(24, 13);
            this.cityName.TabIndex = 8;
            this.cityName.Text = "&City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(502, 108);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(133, 20);
            this.city.TabIndex = 9;
            // 
            // st
            // 
            this.st.AutoSize = true;
            this.st.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st.Location = new System.Drawing.Point(641, 126);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(32, 13);
            this.st.TabIndex = 10;
            this.st.Text = "&State";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(641, 108);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(33, 20);
            this.state.TabIndex = 11;
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
            this.zip.TabIndex = 12;
            this.zip.Text = "&Zip";
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(680, 108);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(59, 20);
            this.zipCode.TabIndex = 13;
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(272, 111);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(45, 13);
            this.add2.TabIndex = 6;
            this.add2.Text = "A&ddress";
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(319, 108);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(162, 20);
            this.address2.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(647, 189);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(92, 23);
            this.submit.TabIndex = 100;
            this.submit.Text = "&Submit Survey";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // nextPerson
            // 
            this.nextPerson.Location = new System.Drawing.Point(664, 160);
            this.nextPerson.Name = "nextPerson";
            this.nextPerson.Size = new System.Drawing.Size(75, 23);
            this.nextPerson.TabIndex = 101;
            this.nextPerson.TabStop = false;
            this.nextPerson.Text = "Next >>";
            this.nextPerson.UseVisualStyleBackColor = true;
            this.nextPerson.Click += new System.EventHandler(this.nextPerson_Click);
            // 
            // previousPerson
            // 
            this.previousPerson.Enabled = false;
            this.previousPerson.Location = new System.Drawing.Point(583, 160);
            this.previousPerson.Name = "previousPerson";
            this.previousPerson.Size = new System.Drawing.Size(75, 23);
            this.previousPerson.TabIndex = 102;
            this.previousPerson.TabStop = false;
            this.previousPerson.Text = "<< Back";
            this.previousPerson.UseVisualStyleBackColor = true;
            this.previousPerson.Click += new System.EventHandler(this.previousPerson_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(291, 46);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(90, 13);
            this.phone.TabIndex = 17;
            this.phone.Text = "Phone Number";
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.SteelBlue;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.Color.White;
            this.phoneNumber.FormattingEnabled = true;
            this.phoneNumber.Location = new System.Drawing.Point(388, 42);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(164, 21);
            this.phoneNumber.TabIndex = 18;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(696, 44);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 103;
            this.status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // noAnswer
            // 
            this.noAnswer.Location = new System.Drawing.Point(477, 160);
            this.noAnswer.Name = "noAnswer";
            this.noAnswer.Size = new System.Drawing.Size(75, 23);
            this.noAnswer.TabIndex = 104;
            this.noAnswer.TabStop = false;
            this.noAnswer.Text = "No Answer";
            this.noAnswer.UseVisualStyleBackColor = true;
            this.noAnswer.Click += new System.EventHandler(this.noAnswer_Click);
            // 
            // mainSurvey
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 222);
            this.Controls.Add(this.noAnswer);
            this.Controls.Add(this.status);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.previousPerson);
            this.Controls.Add(this.nextPerson);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.state);
            this.Controls.Add(this.st);
            this.Controls.Add(this.city);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainSurvey_FormClosing);
            this.mainSurveyToolbar.ResumeLayout(false);
            this.mainSurveyToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainSurveyToolbar;
        private System.Windows.Forms.ToolStripButton startSurvey;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox survey;
        private System.Windows.Forms.Label personSection;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label add1;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label zip;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button nextPerson;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox groupFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button previousPerson;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.ComboBox phoneNumber;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button noAnswer;
    }
}

