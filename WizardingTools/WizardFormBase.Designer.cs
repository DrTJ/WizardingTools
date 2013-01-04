namespace WizardingTools
{
    partial class WizardFormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardFormBase));
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.cancelWizardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.placeHolderPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.titleLabel.Location = new System.Drawing.Point(146, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(541, 39);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "عنوان صفحه";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("B Farnaz", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.descriptionLabel.Location = new System.Drawing.Point(146, 44);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(508, 27);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "توضیحات";
            // 
            // cancelWizardButton
            // 
            this.cancelWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelWizardButton.Image = global::WizardingTools.Properties.Resources.Log_Out;
            this.cancelWizardButton.Location = new System.Drawing.Point(12, 418);
            this.cancelWizardButton.Name = "cancelWizardButton";
            this.cancelWizardButton.Size = new System.Drawing.Size(113, 42);
            this.cancelWizardButton.TabIndex = 7;
            this.cancelWizardButton.Text = "انصراف";
            this.cancelWizardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelWizardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelWizardButton.UseVisualStyleBackColor = true;
            this.cancelWizardButton.Click += new System.EventHandler(this.cancelWizardButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Image = global::WizardingTools.Properties.Resources.Back;
            this.backButton.Location = new System.Drawing.Point(450, 418);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 42);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "بازگشت";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Image = global::WizardingTools.Properties.Resources.Next;
            this.nextButton.Location = new System.Drawing.Point(569, 418);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(113, 42);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "ادامه";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::WizardingTools.Properties.Resources.Book_of_a_Wizard_by_st3to___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // placeHolderPanel
            // 
            this.placeHolderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.placeHolderPanel.Location = new System.Drawing.Point(146, 74);
            this.placeHolderPanel.Name = "placeHolderPanel";
            this.placeHolderPanel.Size = new System.Drawing.Size(536, 338);
            this.placeHolderPanel.TabIndex = 11;
            // 
            // WizardFormBase
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 472);
            this.ControlBox = true;
            this.Controls.Add(this.placeHolderPanel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelWizardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WizardFormBase";
            this.Text = "ویزارد1";
            this.Load += new System.EventHandler(this.SodoorKartWizardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button nextButton;
        protected System.Windows.Forms.Button backButton;
        protected System.Windows.Forms.Button cancelWizardButton;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label titleLabel;
        protected System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Panel placeHolderPanel;
    }
}
