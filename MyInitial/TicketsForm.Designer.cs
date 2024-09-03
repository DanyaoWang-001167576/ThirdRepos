namespace Ticketing
{
    partial class TicketsForm
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.radBalcony = new System.Windows.Forms.RadioButton();
            this.radGeneral = new System.Windows.Forms.RadioButton();
            this.radBox = new System.Windows.Forms.RadioButton();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.radBack = new System.Windows.Forms.RadioButton();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(96, 92);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 25);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(222, 92);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(178, 31);
            this.txtQuantity.TabIndex = 1;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(488, 92);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(130, 25);
            this.lblAmountDue.TabIndex = 2;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(654, 102);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 25);
            this.lblAmount.TabIndex = 3;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(222, 183);
            this.chkDiscount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(198, 29);
            this.chkDiscount.TabIndex = 5;
            this.chkDiscount.Text = "Senior / Student";
            this.chkDiscount.UseVisualStyleBackColor = true;
            // 
            // radBalcony
            // 
            this.radBalcony.AutoSize = true;
            this.radBalcony.Location = new System.Drawing.Point(52, 33);
            this.radBalcony.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radBalcony.Name = "radBalcony";
            this.radBalcony.Size = new System.Drawing.Size(120, 29);
            this.radBalcony.TabIndex = 6;
            this.radBalcony.Text = "Balcony";
            this.radBalcony.UseVisualStyleBackColor = true;
            // 
            // radGeneral
            // 
            this.radGeneral.AutoSize = true;
            this.radGeneral.Checked = true;
            this.radGeneral.Location = new System.Drawing.Point(52, 77);
            this.radGeneral.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radGeneral.Name = "radGeneral";
            this.radGeneral.Size = new System.Drawing.Size(119, 29);
            this.radGeneral.TabIndex = 7;
            this.radGeneral.TabStop = true;
            this.radGeneral.Text = "General";
            this.radGeneral.UseVisualStyleBackColor = true;
            // 
            // radBox
            // 
            this.radBox.AutoSize = true;
            this.radBox.Location = new System.Drawing.Point(52, 121);
            this.radBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radBox.Name = "radBox";
            this.radBox.Size = new System.Drawing.Size(141, 29);
            this.radBox.TabIndex = 8;
            this.radBox.Text = "Box Seats";
            this.radBox.UseVisualStyleBackColor = true;
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.radBack);
            this.grpSection.Controls.Add(this.radBox);
            this.grpSection.Controls.Add(this.radGeneral);
            this.grpSection.Controls.Add(this.radBalcony);
            this.grpSection.Location = new System.Drawing.Point(104, 271);
            this.grpSection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpSection.Name = "grpSection";
            this.grpSection.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpSection.Size = new System.Drawing.Size(278, 213);
            this.grpSection.TabIndex = 9;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Section";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(588, 515);
            this.cmdCalculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(216, 67);
            this.cmdCalculate.TabIndex = 10;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // radBack
            // 
            this.radBack.AutoSize = true;
            this.radBack.Location = new System.Drawing.Point(52, 175);
            this.radBack.Name = "radBack";
            this.radBack.Size = new System.Drawing.Size(150, 29);
            this.radBack.TabIndex = 9;
            this.radBack.TabStop = true;
            this.radBack.Text = "Back Stalls";
            this.radBack.UseVisualStyleBackColor = true;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 856);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TicketsForm";
            this.Text = "Theater Ticket Purchase";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.RadioButton radBalcony;
        private System.Windows.Forms.RadioButton radGeneral;
        private System.Windows.Forms.RadioButton radBox;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.RadioButton radBack;
    }
}

