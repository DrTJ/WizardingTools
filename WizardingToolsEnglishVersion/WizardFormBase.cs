using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WizardingToolsEnglishVersion
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



        protected void GoForward(WizardingToolsEnglishVersion.WizardPanel currentPanel, WizardingToolsEnglishVersion.WizardPanel nextPanel)
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

        protected void GoBackward(WizardingToolsEnglishVersion.WizardPanel panel)
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

        protected void UpdateForm(WizardingToolsEnglishVersion.WizardPanel panel)
        {
            this.titleLabel.Text = panel.Title;
            this.descriptionLabel.Text = panel.Description;
        }



        private void nextButton_Click(object sender, EventArgs e)
        {
            if (this.ActivePanel != null)
                this.ActivePanel.ShowNextPanel();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.ActivePanel != null)
                this.ActivePanel.ShowPreviousePanel();

            GoBackward(this.ActivePanel);
        }
        
        private void cancelWizardButton_Click(object sender, EventArgs e)
        {
            if (this.ActivePanel != null)
            {
                this.ActivePanel.CancelingWizard();
                this.ActivePanel.CancelWizard();
                this.ActivePanel.WizardCanceled();
            }
        }
    }
}
