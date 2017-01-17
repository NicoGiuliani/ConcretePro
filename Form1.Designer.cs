namespace Concrete_Pro
{
  partial class frmConcrete
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConcrete));
      this.btnClear = new System.Windows.Forms.Button();
      this.grpCustomerType = new System.Windows.Forms.GroupBox();
      this.radCommercial = new System.Windows.Forms.RadioButton();
      this.radPrivate = new System.Windows.Forms.RadioButton();
      this.grpDimensions = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDepth = new System.Windows.Forms.TextBox();
      this.txtWidth = new System.Windows.Forms.TextBox();
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
      this.cmbState = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtZip = new System.Windows.Forms.TextBox();
      this.txtCity = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtColor = new System.Windows.Forms.TextBox();
      this.chkColor = new System.Windows.Forms.CheckBox();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lblCost = new System.Windows.Forms.Label();
      this.lblVolume = new System.Windows.Forms.Label();
      this.grpCustomerType.SuspendLayout();
      this.grpDimensions.SuspendLayout();
      this.grpCustomerInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(375, 127);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(114, 23);
      this.btnClear.TabIndex = 16;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // grpCustomerType
      // 
      this.grpCustomerType.Controls.Add(this.radCommercial);
      this.grpCustomerType.Controls.Add(this.radPrivate);
      this.grpCustomerType.Location = new System.Drawing.Point(374, 12);
      this.grpCustomerType.Name = "grpCustomerType";
      this.grpCustomerType.Size = new System.Drawing.Size(115, 71);
      this.grpCustomerType.TabIndex = 12;
      this.grpCustomerType.TabStop = false;
      this.grpCustomerType.Text = "Type";
      // 
      // radCommercial
      // 
      this.radCommercial.AutoSize = true;
      this.radCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radCommercial.Location = new System.Drawing.Point(14, 43);
      this.radCommercial.Name = "radCommercial";
      this.radCommercial.Size = new System.Drawing.Size(92, 19);
      this.radCommercial.TabIndex = 14;
      this.radCommercial.TabStop = true;
      this.radCommercial.Text = "Commercial";
      this.radCommercial.UseVisualStyleBackColor = true;
      this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
      // 
      // radPrivate
      // 
      this.radPrivate.AutoSize = true;
      this.radPrivate.Checked = true;
      this.radPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radPrivate.Location = new System.Drawing.Point(14, 18);
      this.radPrivate.Name = "radPrivate";
      this.radPrivate.Size = new System.Drawing.Size(62, 19);
      this.radPrivate.TabIndex = 13;
      this.radPrivate.TabStop = true;
      this.radPrivate.Text = "Private";
      this.radPrivate.UseVisualStyleBackColor = true;
      this.radPrivate.CheckedChanged += new System.EventHandler(this.radPrivate_CheckedChanged);
      // 
      // grpDimensions
      // 
      this.grpDimensions.Controls.Add(this.label3);
      this.grpDimensions.Controls.Add(this.label2);
      this.grpDimensions.Controls.Add(this.txtDepth);
      this.grpDimensions.Controls.Add(this.txtWidth);
      this.grpDimensions.Controls.Add(this.txtHeight);
      this.grpDimensions.Controls.Add(this.label1);
      this.grpDimensions.Enabled = false;
      this.grpDimensions.Location = new System.Drawing.Point(206, 12);
      this.grpDimensions.Name = "grpDimensions";
      this.grpDimensions.Size = new System.Drawing.Size(162, 111);
      this.grpDimensions.TabIndex = 6;
      this.grpDimensions.TabStop = false;
      this.grpDimensions.Text = "Dimensions in feet";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(14, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 15);
      this.label3.TabIndex = 49;
      this.label3.Text = "Depth";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(16, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 15);
      this.label2.TabIndex = 48;
      this.label2.Text = "Width";
      // 
      // txtDepth
      // 
      this.txtDepth.Location = new System.Drawing.Point(60, 75);
      this.txtDepth.Name = "txtDepth";
      this.txtDepth.Size = new System.Drawing.Size(88, 20);
      this.txtDepth.TabIndex = 9;
      this.txtDepth.TextChanged += new System.EventHandler(this.txtDepth_TextChanged);
      // 
      // txtWidth
      // 
      this.txtWidth.Location = new System.Drawing.Point(60, 48);
      this.txtWidth.Name = "txtWidth";
      this.txtWidth.Size = new System.Drawing.Size(88, 20);
      this.txtWidth.TabIndex = 8;
      this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
      // 
      // txtHeight
      // 
      this.txtHeight.Location = new System.Drawing.Point(60, 20);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(88, 20);
      this.txtHeight.TabIndex = 7;
      this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(11, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 15);
      this.label1.TabIndex = 47;
      this.label1.Text = "Height";
      // 
      // grpCustomerInfo
      // 
      this.grpCustomerInfo.Controls.Add(this.cmbState);
      this.grpCustomerInfo.Controls.Add(this.label8);
      this.grpCustomerInfo.Controls.Add(this.label7);
      this.grpCustomerInfo.Controls.Add(this.label6);
      this.grpCustomerInfo.Controls.Add(this.label5);
      this.grpCustomerInfo.Controls.Add(this.label4);
      this.grpCustomerInfo.Controls.Add(this.txtZip);
      this.grpCustomerInfo.Controls.Add(this.txtCity);
      this.grpCustomerInfo.Controls.Add(this.txtAddress);
      this.grpCustomerInfo.Controls.Add(this.txtName);
      this.grpCustomerInfo.Location = new System.Drawing.Point(12, 12);
      this.grpCustomerInfo.Name = "grpCustomerInfo";
      this.grpCustomerInfo.Size = new System.Drawing.Size(188, 174);
      this.grpCustomerInfo.TabIndex = 0;
      this.grpCustomerInfo.TabStop = false;
      this.grpCustomerInfo.Text = "Customer Info";
      // 
      // cmbState
      // 
      this.cmbState.FormattingEnabled = true;
      this.cmbState.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii  ",
            "Idaho  ",
            "Illinois ",
            "Indiana ",
            "Iowa ",
            "Kansas",
            "Kentucky ",
            "Louisiana  ",
            "Maine  ",
            "Maryland ",
            "Massachusetts  ",
            "Michigan",
            "Minnesota  ",
            "Mississippi  ",
            "Missouri ",
            "Montana ",
            "Nebraska  ",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania",
            "Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming "});
      this.cmbState.Location = new System.Drawing.Point(60, 114);
      this.cmbState.Name = "cmbState";
      this.cmbState.Size = new System.Drawing.Size(116, 21);
      this.cmbState.TabIndex = 4;
      this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(27, 144);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(24, 15);
      this.label8.TabIndex = 45;
      this.label8.Text = "Zip";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(19, 115);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(35, 15);
      this.label7.TabIndex = 44;
      this.label7.Text = "State";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(27, 86);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(26, 15);
      this.label6.TabIndex = 43;
      this.label6.Text = "City";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(6, 51);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(51, 15);
      this.label5.TabIndex = 42;
      this.label5.Text = "Address";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(16, 21);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 15);
      this.label4.TabIndex = 41;
      this.label4.Text = "Name";
      // 
      // txtZip
      // 
      this.txtZip.Location = new System.Drawing.Point(60, 144);
      this.txtZip.Name = "txtZip";
      this.txtZip.Size = new System.Drawing.Size(116, 20);
      this.txtZip.TabIndex = 5;
      this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
      // 
      // txtCity
      // 
      this.txtCity.Location = new System.Drawing.Point(61, 83);
      this.txtCity.Name = "txtCity";
      this.txtCity.Size = new System.Drawing.Size(115, 20);
      this.txtCity.TabIndex = 3;
      this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(61, 51);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(115, 20);
      this.txtAddress.TabIndex = 2;
      this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(61, 18);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(115, 20);
      this.txtName.TabIndex = 1;
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      // 
      // txtColor
      // 
      this.txtColor.Enabled = false;
      this.txtColor.Location = new System.Drawing.Point(280, 144);
      this.txtColor.Name = "txtColor";
      this.txtColor.Size = new System.Drawing.Size(76, 20);
      this.txtColor.TabIndex = 11;
      this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
      // 
      // chkColor
      // 
      this.chkColor.AutoSize = true;
      this.chkColor.Location = new System.Drawing.Point(206, 146);
      this.chkColor.Name = "chkColor";
      this.chkColor.Size = new System.Drawing.Size(77, 17);
      this.chkColor.TabIndex = 10;
      this.chkColor.Text = "Add color?";
      this.chkColor.UseVisualStyleBackColor = true;
      this.chkColor.CheckedChanged += new System.EventHandler(this.chkColor_CheckedChanged);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(374, 156);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(115, 23);
      this.btnExit.TabIndex = 17;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(374, 98);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(115, 23);
      this.btnCalculate.TabIndex = 15;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // lblCost
      // 
      this.lblCost.AutoSize = true;
      this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCost.Location = new System.Drawing.Point(237, 237);
      this.lblCost.Name = "lblCost";
      this.lblCost.Size = new System.Drawing.Size(0, 25);
      this.lblCost.TabIndex = 36;
      this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblVolume
      // 
      this.lblVolume.AutoSize = true;
      this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVolume.Location = new System.Drawing.Point(237, 203);
      this.lblVolume.Name = "lblVolume";
      this.lblVolume.Size = new System.Drawing.Size(0, 25);
      this.lblVolume.TabIndex = 35;
      this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmConcrete
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.ClientSize = new System.Drawing.Size(497, 279);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.grpCustomerType);
      this.Controls.Add(this.grpDimensions);
      this.Controls.Add(this.grpCustomerInfo);
      this.Controls.Add(this.txtColor);
      this.Controls.Add(this.chkColor);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.lblCost);
      this.Controls.Add(this.lblVolume);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "frmConcrete";
      this.Text = "Concrete Pro";
      this.grpCustomerType.ResumeLayout(false);
      this.grpCustomerType.PerformLayout();
      this.grpDimensions.ResumeLayout(false);
      this.grpDimensions.PerformLayout();
      this.grpCustomerInfo.ResumeLayout(false);
      this.grpCustomerInfo.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.GroupBox grpCustomerType;
    private System.Windows.Forms.RadioButton radCommercial;
    private System.Windows.Forms.RadioButton radPrivate;
    private System.Windows.Forms.GroupBox grpDimensions;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtDepth;
    private System.Windows.Forms.TextBox txtWidth;
    private System.Windows.Forms.TextBox txtHeight;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox grpCustomerInfo;
    private System.Windows.Forms.ComboBox cmbState;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtZip;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.CheckBox chkColor;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label lblCost;
    private System.Windows.Forms.Label lblVolume;
  }
}

