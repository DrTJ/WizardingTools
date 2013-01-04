using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WizardingTools
{
    public partial class WizardFormBase : BaseForm
    {
        public WizardPanel ActivePanel { get; set; }

        public WizardFormBase()
        {
            InitializeComponent();

            this.ActivePanel = null;
        }

        private void SodoorKartWizardForm_Load(object sender, EventArgs e)
        {
            
        }



        protected void GoForward(WizardingTools.WizardPanel currentPanel, WizardingTools.WizardPanel nextPanel)
        {
            nextPanel.PreviousePanel = currentPanel;
            this.ActivePanel = nextPanel;

            if (currentPanel != null)
                currentPanel.Visible = false;

            nextPanel.Visible = true;
            nextPanel.Load();

            if (this.ActivePanel != null)
                UpdateForm();
        }

        protected void GoBackward(WizardingTools.WizardPanel panel)
        {
            if (panel != null)
                if (panel.PreviousePanel != null)
                {
                    panel.Visible = false;
                    panel.PreviousePanel.Visible = true;

                    this.ActivePanel = panel.PreviousePanel;

                    UpdateForm();
                }
        }

        protected void UpdateForm()
        {
            UpdateForm(this.ActivePanel);
        }

        protected void UpdateForm(WizardingTools.WizardPanel panel)
        {
            this.titleLabel.Text = panel.Title;
            this.descriptionLabel.Text = panel.Description;
        }



        private void nextButton_Click(object sender, EventArgs e)
        {
            if (this.ActivePanel != null)
                this.ActivePanel.ShowNextPanel();

           // MessageBox.Show("Next");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.ActivePanel != null)
                this.ActivePanel.ShowPreviousePanel();

            GoBackward(this.ActivePanel);

           // MessageBox.Show("Back");
        }

        

        private void cancelWizardButton_Click(object sender, EventArgs e)
        {
            if (this.ActivePanel != null)
            {
                this.ActivePanel.CancelingWizard();
                this.ActivePanel.CancelWizard();
                this.ActivePanel.WizardCanceled();
            }

            //MessageBox.Show("Cancel");
        }
    }
}
