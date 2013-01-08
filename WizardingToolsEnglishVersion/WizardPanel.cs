using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace WizardingToolsEnglishVersion
{
    public delegate void PanelChangingEventHandler(WizardPanel currentPanel);
    public delegate void WizardCancelingEventHandler(WizardPanel currentPanel, bool cancel);

    [DefaultEvent("OnShowNextPanel")]
    [DefaultProperty("Title")]
    public partial class WizardPanel:Panel
    {
        [DefaultValue("Page Title")]
        public string Title { get; set; }

        [DefaultValue("Description")]
        public string Description { get; set; }

        public WizardPanel PreviousePanel { get; set; }

        public event PanelChangingEventHandler OnShowNextPanel;
        public event PanelChangingEventHandler OnShowPreviousePanel;
        public event PanelChangingEventHandler OnCancelWizard;
        public event PanelChangingEventHandler OnLoad;

        public event WizardCancelingEventHandler OnCancelingWizard;
        public event WizardCancelingEventHandler OnWizardCanceled;
   
        
        public WizardPanel()
            : base()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;
        }


        public void ShowPreviousePanel()
        {
            if (this.OnShowPreviousePanel != null)
                OnShowPreviousePanel(this);
        }

        public void ShowNextPanel()
        {
            if (this.OnShowNextPanel != null)
                OnShowNextPanel(this);
        }

        public void CancelWizard()
        {
            if (this.OnCancelWizard != null)
                OnCancelWizard(this);
        }

        public void Load()
        {
            if (this.OnLoad != null)
                OnLoad(this);
        }





        public void CancelingWizard()
        {
            if (this.OnCancelingWizard != null)
                OnCancelingWizard(this, false);
        }

        public void WizardCanceled()
        {
            if (this.OnWizardCanceled != null)
                OnWizardCanceled(this, true);
        }

        
    }
}
