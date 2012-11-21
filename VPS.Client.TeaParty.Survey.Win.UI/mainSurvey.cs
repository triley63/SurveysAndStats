using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPS.Client.TeaParty.Survey.Win.UI
{
    public partial class mainSurvey : Form
    {
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
                    this.Controls.Add(answer);

                    Panel p = new Panel();
                    p.Top = top - 8;
                    p.Left = answer.Left + answer.Width + 28;
                    p.Width = 245;
                    p.Height = 27;

                    for (int i = 1; i < 6; i++)
                    {
                        RadioButton radio = new RadioButton();
                        radio.Name = string.Format("Q{0}A{1}", quest.ToString(), i);
                        radio.Text = i.ToString();
                        radio.AutoSize = true;
                        radio.Left = 10 + ((i - 1) * 40);
                        radio.Top = 3;
                        radio.Click += radio_Click;
                        p.Controls.Add(radio);
                    }

                    this.Controls.Add(p);

                    top = top + 30;
                    quest++;
                }
            }
        }

        void radio_Click(object sender, EventArgs e)
        {
            RadioButton button = ((RadioButton)sender);
            


            MessageBox.Show(((RadioButton)sender).Name);
        }

        private void survey_TextChanged(object sender, EventArgs e)
        {
            InitializeQuestions();
        }

    }
}
