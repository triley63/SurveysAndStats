using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VPS.Client.TeaParty.Survey.Win.UI
{
    public partial class mainSurvey : Form
    {
        private bool isSaved = true;
        private IList<Person> surveyGroup = new List<Person>();
        private int currentSurvey = 0;
        private Person currentPerson;

        public mainSurvey()
        {
            InitializeComponent();
            InitializeSurveyGroup();
            InitializeSurveyList();

            this.groupFilter.SelectedIndex = 0;
            
        }

        private void InitializeSurveyList()
        {
            string[] surveys = System.Configuration.ConfigurationManager.AppSettings.AllKeys;
            foreach (string survey in surveys)
            {
                if (survey != "SurveyGroup")
                    this.survey.Items.Add(survey);
            }
        }

        private void InitializeQuestions()
        {
            int left = this.add1.Left;
            int top = this.nextPerson.Top + 40;
            int quest = 1;

            using (StreamReader sr = new StreamReader(ConfigurationManager.AppSettings[this.survey.Text]))
            {
                string question;
                while ((question = sr.ReadLine()) != null)
                {
                    Label currentQuestion = new Label();
                    
                    currentQuestion.Text = question;
                    currentQuestion.Left = left;
                    currentQuestion.Top = top;
                    currentQuestion.AutoSize = true;
                    currentQuestion.Name = string.Format("Q{0}", quest.ToString());
                    this.Controls.Add(currentQuestion);

                    TextBox answer = new TextBox();
                    answer.Left = 450;
                    answer.Top = top - 4;
                    answer.Width = 25;
                    answer.TextAlign = HorizontalAlignment.Center;
                    answer.Name = string.Format("A{0}", quest.ToString());
                    answer.TabIndex = 13 + quest;
                    answer.TextChanged += answer_TextChanged;
                    answer.KeyPress += answer_KeyPress;
                    this.Controls.Add(answer);

                    Panel p = new Panel();
                    p.Top = top - 8;
                    p.Left = answer.Left + answer.Width + 28;
                    p.Width = 245;
                    p.Height = 27;
                    p.Name = string.Format("P{0}", quest.ToString());

                    for (int i = 1; i < 6; i++)
                    {
                        RadioButton radio = new RadioButton();
                        radio.Name = string.Format("Q{0}A{1}", quest.ToString(), i);
                        radio.Text = i.ToString();
                        radio.AutoSize = true;
                        radio.Left = 10 + ((i - 1) * 40);
                        radio.Top = 3;
                        radio.TabIndex = 100;
                        radio.Click += radio_Click;
                        p.Controls.Add(radio);
                    }

                    this.Controls.Add(p);

                    this.submit.Top += 30;
                    this.submit.TabIndex++;
                    this.Height += 30;
                    top = top + 30;
                    quest++;
                }
            }
            this.lastName.Select();
        }

        private void InitializeSurveyGroup()
        {
            using (StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["SurveyGroup"]))
            {
                string personRecord;
                while ((personRecord = sr.ReadLine()) != null)
                {
                    string[] newPerson = personRecord.Split(',');
                    CallStatus status = CallStatus.Uncalled;
                    switch (newPerson[0])
                    {
                        case "Uncalled": status = CallStatus.Uncalled; break;
                        case "Called": status = CallStatus.Called; break;
                        case "NoAnswer": status= CallStatus.NoAnswer; break;
                    }

                    surveyGroup.Add(new Person(
                        status
                        ,int.Parse(newPerson[1])
                        , newPerson[2]
                        , newPerson[3]
                        , newPerson[4]
                        ,newPerson[5]
                        ,newPerson[6]
                        ,newPerson[7]
                        ,newPerson[8]));

                    for (int i = 9; i < newPerson.Length; i++)
                    {
                        if (newPerson[i].IndexOf("(e)") == -1)
                        {
                            surveyGroup[surveyGroup.Count - 1].AddPhone(newPerson[i]);
                        }
                    }
                }
            }
        }

        private void startSurvey_Click(object sender, EventArgs e)
        {
            nextPerson_Click(null, null);
        }

        private void nextPerson_Click(object sender, EventArgs e)
        {
            if (isSaved)
            {
                if (this.nextPerson.Enabled = this.currentSurvey < surveyGroup.Count && currentSurvey >= 0)
                    currentPerson = surveyGroup[currentSurvey];
                else
                {
                    MessageBox.Show("There are no more in this category!");
                    return;
                }

                foreach (Control c in this.Controls)
                {
                    TextBox tb = c as TextBox;
                    Panel p = c as Panel;
                    if (tb != null)
                        tb.Text = string.Empty;

                    if (p != null)
                    {
                        foreach (Control cp in p.Controls)
                        {
                            RadioButton rb = cp as RadioButton;
                            if (rb != null)
                                rb.Checked = false;
                        }
                    }
                }

                if (currentPerson.Status.ToString() == this.groupFilter.Text || this.groupFilter.Text == "All")
                {
                    this.lastName.Text = currentPerson.LastName;
                    this.firstName.Text = currentPerson.FirstName;
                    this.address1.Text = currentPerson.Address1;
                    this.address2.Text = currentPerson.Address2;
                    this.city.Text = currentPerson.City;
                    this.state.Text = currentPerson.State;
                    this.zipCode.Text = currentPerson.Zip;
                    this.status.Text = currentPerson.Status.ToString();

                    this.phoneNumber.Items.Clear();
                    for (int i = 0; i < currentPerson.Phone.Count; i++)
                    {
                        this.phoneNumber.Items.Add(currentPerson.Phone[i]);
                    }

                    if (this.phoneNumber.Items.Count == 0)
                    {
                        this.phoneNumber.Items.Clear();
                        this.phoneNumber.Text = "";
                        MessageBox.Show(string.Format("There is no phone number for {0} {1}", currentPerson.FirstName, currentPerson.LastName));
                    }
                    else
                    {
                        this.phoneNumber.SelectedIndex = 0;
                        this.phone.ForeColor = this.phoneNumber.Items.Count == 1 ? System.Drawing.Color.Black : System.Drawing.Color.Red;
                        this.phone.Text = this.phoneNumber.Items.Count == 1 ? this.phone.Text = "Phone Number" : "Phone Numbers";
                    }
                }
                else
                {
                    if (sender != null && ((Button)sender).Text == "<< Back")
                        currentSurvey--;
                    else
                        currentSurvey++;

                    nextPerson_Click(null, null);
                }

                this.isSaved = false;
            }
            else
            {
                string results = GetAnswers().ToString();
                if (results.Substring(results.IndexOf(',')).Replace(",", string.Empty).Trim().Length == 0)
                {
                    if (this.currentSurvey < 0)
                    {
                        MessageBox.Show("You are at the beginning of the list");
                        return;
                    }

                    if (((Button)sender).Text == "<< Back")
                    {
                        currentSurvey--;
                        this.isSaved = true;
                        nextPerson_Click(previousPerson, null);
                    }
                    else
                    {
                        this.isSaved = true;
                        currentSurvey++;
                        nextPerson_Click(nextPerson, null);
                    }
                }
                else
                {
                    MessageBox.Show("This survey has not been saved");
                }

            }

            this.previousPerson.Enabled = this.currentSurvey > 0;
            this.nextPerson.Enabled = this.currentSurvey < surveyGroup.Count - 1;
        }

        private void previousPerson_Click(object sender, EventArgs e)
        {
            this.currentSurvey--;
            nextPerson_Click(previousPerson, null);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            StringBuilder surveyResults = new StringBuilder();
            surveyResults.Append(string.Format("{0},", currentPerson.ID.ToString()));

            for (int i = 1; i < this.Controls.OfType<Panel>().Count()+1; i++)
            {
                TextBox tb = (TextBox)this.Controls.Find(string.Format("A{0}", i.ToString()), false)[0];
                surveyResults.Append(string.Format("{0},", tb.Text.Replace(",", " ")));
            }

            using (StreamWriter sw = new StreamWriter("ThirdPartyAnswers.txt", true))
            {
                sw.WriteLine(surveyResults.ToString().Substring(0, surveyResults.Length - 1));
            }

            this.isSaved = true;
            MessageBox.Show("The survey has been submitted");

            this.currentPerson.Status = CallStatus.Called;

            if (surveyGroup.Count > currentSurvey)
                nextPerson_Click(submit, null);
            else
                MessageBox.Show("There are no others listed in this survey group!");
        }

        void answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex reg = new Regex("[1-5]");
            if (reg.IsMatch(e.KeyChar.ToString()) == false)
                e.Handled = !char.IsControl(e.KeyChar);
                //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && int.Parse(Convert.ToChar(e.KeyChar).ToString()) < 6;
        }

        void answer_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != string.Empty)
            {
                Control[] c = this.Controls.Find(string.Format("P{0}", tb.Name.Substring(1, 1)), false);
                Control[] r = c[0].Controls.Find(string.Format("Q{0}A{1}", tb.Name.Substring(1, 1), ((TextBox)sender).Text), false);
                RadioButton rb = (RadioButton)r[0];
                rb.Checked = true;

                SendKeys.Send("{TAB}");
            }
            tb.Select();
        }   

        void radio_Click(object sender, EventArgs e)
        {
            RadioButton button = ((RadioButton)sender);

            foreach (Control c in Controls)
            {
                TextBox tb = c as TextBox;
                if (tb != null)
                {
                    if (tb.Name == string.Format("A{0}", button.Name.Substring(1, 1)))
                        tb.Text = button.Text;
                }
            }
        }

        private void survey_TextChanged(object sender, EventArgs e)
        {
            InitializeQuestions();
        }



        private void groupFilter_Click(object sender, EventArgs e)
        {

        }

        private StringBuilder GetAnswers()
        {
            StringBuilder surveyResults = new StringBuilder();
            surveyResults.Append(string.Format("{0},", currentPerson.ID.ToString()));

            for (int i = 1; i < this.Controls.OfType<Panel>().Count() + 1; i++)
            {
                TextBox tb = (TextBox)this.Controls.Find(string.Format("A{0}", i.ToString()), false)[0];
                surveyResults.Append(string.Format("{0},", tb.Text.Replace(",", " ")));
            }

            return surveyResults;
        }

        private void mainSurvey_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter dw = new StreamWriter(ConfigurationManager.AppSettings["SurveyGroup"]))
            {
                foreach (Person p in surveyGroup)
                {
                    dw.WriteLine(p.Join());
                }
            }
        }

        private void noAnswer_Click(object sender, EventArgs e)
        {
            this.currentPerson.Status = CallStatus.NoAnswer;
            nextPerson_Click(noAnswer, null);
        }




    }
}
