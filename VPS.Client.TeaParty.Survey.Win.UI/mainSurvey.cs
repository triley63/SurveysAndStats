using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VPS.Client.TeaParty.Survey.Win.UI
{
    public partial class mainSurvey : Form
    {
        private bool isSaved;

        public mainSurvey()
        {
            InitializeComponent();
            InitializeSurveyList();
            
        }

        private void InitializeSurveyList()
        {
            string[] surveys = System.Configuration.ConfigurationManager.AppSettings.AllKeys;
            foreach (string survey in surveys)
            {
                this.survey.Items.Add(survey);
            }
        }

        private void InitializeQuestions()
        {
            int left = this.add1.Left;
            int top = this.add1.Top + 50;
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

        void answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex reg = new Regex("[1-5]");
            if (reg.IsMatch(e.KeyChar.ToString()) == false)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
                    if (tb.Name == string.Format("A{0}", button.Name.Substring(1,1)))
                        tb.Text = button.Text;
                }
            }
        }

        private void survey_TextChanged(object sender, EventArgs e)
        {
            InitializeQuestions();
        }

        private void newSurvey_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("The survey is not saved for this individidual .. would you like to save now?"
                    , "Save Results"
                    , MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        //save this thing
                        this.isSaved = true;
                        break;
                    case DialogResult.No:
                        this.isSaved = true;
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }

            if (isSaved)
            {
                foreach (Control c in this.Controls)
                {
                    TextBox tb = c as TextBox;
                    Panel p = c as Panel;

                    if (tb != null)
                        tb.Clear();

                    if (p != null)
                    {
                        foreach (Control r in p.Controls)
                        {
                            RadioButton rb = r as RadioButton;
                            if (rb != null)
                                rb.Checked = false;
                        }
                    }
                }

                this.isSaved = false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            StringBuilder surveyResults = new StringBuilder();
            surveyResults.Append(string.Format("{0},", this.lastName.Text.Replace(",", " ")));
            surveyResults.Append(string.Format("{0},", this.firstName.Text.Replace(",", " ")));
            surveyResults.Append(string.Format("{0},", this.address1.Text.Replace(",", " ")));
            surveyResults.Append(string.Format("{0},", this.address2.Text.Replace(",", " ")));
            surveyResults.Append(string.Format("{0},", this.city.Text.Replace(",", " ")));
            surveyResults.Append(string.Format("{0},", this.state.Text.Replace(",", " ")));
            surveyResults.Append(string.Format("{0},", this.zipCode.Text.Replace(",", " ")));

            for (int i = 1; i < this.Controls.OfType<Panel>().Count()+1; i++)
            {
                TextBox tb = (TextBox)this.Controls.Find(string.Format("A{0}", i.ToString()), false)[0];
                surveyResults.Append(string.Format("{0},", tb.Text.Replace(",", " ")));
            }

            using (StreamWriter sw = new StreamWriter("ThirdPartyAnswers.txt",true))
            {
                sw.WriteLine(surveyResults.ToString().Substring(0, surveyResults.Length - 1));
            }

            this.isSaved = true;
            newSurvey_Click(null, null);
            MessageBox.Show("The survey has been submitted");
        }

    }
}
