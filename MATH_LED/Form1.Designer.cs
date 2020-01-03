namespace MATH_LED
{
    partial class MATHLED
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
            this.typeRadioSolid = new System.Windows.Forms.RadioButton();
            this.typeRadioPulse = new System.Windows.Forms.RadioButton();
            this.typeRadioRainbow = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            this.powerRadioOn = new System.Windows.Forms.RadioButton();
            this.powerRadioOff = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.toggleConnectionButton = new System.Windows.Forms.Button();
            this.colorPickerPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.colorPicker = new MATH_LED.HSVColorPicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.colorPickerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeRadioSolid
            // 
            this.typeRadioSolid.AutoSize = true;
            this.typeRadioSolid.Location = new System.Drawing.Point(3, 3);
            this.typeRadioSolid.Name = "typeRadioSolid";
            this.typeRadioSolid.Size = new System.Drawing.Size(48, 17);
            this.typeRadioSolid.TabIndex = 0;
            this.typeRadioSolid.TabStop = true;
            this.typeRadioSolid.Text = "Solid";
            this.typeRadioSolid.UseVisualStyleBackColor = true;
            this.typeRadioSolid.CheckedChanged += new System.EventHandler(this.typeRadioSolid_CheckedChanged);
            // 
            // typeRadioPulse
            // 
            this.typeRadioPulse.AutoSize = true;
            this.typeRadioPulse.Location = new System.Drawing.Point(3, 49);
            this.typeRadioPulse.Name = "typeRadioPulse";
            this.typeRadioPulse.Size = new System.Drawing.Size(51, 17);
            this.typeRadioPulse.TabIndex = 1;
            this.typeRadioPulse.TabStop = true;
            this.typeRadioPulse.Text = "Pulse";
            this.typeRadioPulse.UseVisualStyleBackColor = true;
            this.typeRadioPulse.CheckedChanged += new System.EventHandler(this.typeRadioPulse_CheckedChanged);
            // 
            // typeRadioRainbow
            // 
            this.typeRadioRainbow.AutoSize = true;
            this.typeRadioRainbow.Location = new System.Drawing.Point(3, 26);
            this.typeRadioRainbow.Name = "typeRadioRainbow";
            this.typeRadioRainbow.Size = new System.Drawing.Size(67, 17);
            this.typeRadioRainbow.TabIndex = 3;
            this.typeRadioRainbow.TabStop = true;
            this.typeRadioRainbow.Text = "Rainbow";
            this.typeRadioRainbow.UseVisualStyleBackColor = true;
            this.typeRadioRainbow.CheckedChanged += new System.EventHandler(this.typeRadioRainbow_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(109, 13);
            this.title.TabIndex = 4;
            this.title.Text = "MATH LED Controller";
            // 
            // powerRadioOn
            // 
            this.powerRadioOn.AutoSize = true;
            this.powerRadioOn.Location = new System.Drawing.Point(3, 3);
            this.powerRadioOn.Name = "powerRadioOn";
            this.powerRadioOn.Size = new System.Drawing.Size(39, 17);
            this.powerRadioOn.TabIndex = 13;
            this.powerRadioOn.TabStop = true;
            this.powerRadioOn.Text = "On";
            this.powerRadioOn.UseVisualStyleBackColor = true;
            this.powerRadioOn.CheckedChanged += new System.EventHandler(this.powerRadioOn_CheckedChanged);
            // 
            // powerRadioOff
            // 
            this.powerRadioOff.AutoSize = true;
            this.powerRadioOff.Location = new System.Drawing.Point(3, 26);
            this.powerRadioOff.Name = "powerRadioOff";
            this.powerRadioOff.Size = new System.Drawing.Size(39, 17);
            this.powerRadioOff.TabIndex = 14;
            this.powerRadioOff.TabStop = true;
            this.powerRadioOff.Text = "Off";
            this.powerRadioOff.UseVisualStyleBackColor = true;
            this.powerRadioOff.CheckedChanged += new System.EventHandler(this.powerRadioOff_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.typeRadioSolid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.typeRadioPulse, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.typeRadioRainbow, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 69);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.powerRadioOn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.powerRadioOff, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 236);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 48);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.portComboBox);
            this.flowLayoutPanel1.Controls.Add(this.toggleConnectionButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 287);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 76);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(3, 3);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 0;
            // 
            // toggleConnectionButton
            // 
            this.toggleConnectionButton.Location = new System.Drawing.Point(3, 30);
            this.toggleConnectionButton.Name = "toggleConnectionButton";
            this.toggleConnectionButton.Size = new System.Drawing.Size(121, 40);
            this.toggleConnectionButton.TabIndex = 1;
            this.toggleConnectionButton.Text = "Connect";
            this.toggleConnectionButton.UseVisualStyleBackColor = true;
            this.toggleConnectionButton.Click += new System.EventHandler(this.toggleConnectionButton_Click);
            // 
            // colorPickerPanel
            // 
            this.colorPickerPanel.AutoSize = true;
            this.colorPickerPanel.Controls.Add(this.colorPicker);
            this.colorPickerPanel.Location = new System.Drawing.Point(179, 9);
            this.colorPickerPanel.Name = "colorPickerPanel";
            this.colorPickerPanel.Size = new System.Drawing.Size(353, 354);
            this.colorPickerPanel.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(0, 0);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(350, 350);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.HSVColorChanged += colorPicker_HSVColorChanged;
            // 
            // MATHLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorPickerPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.title);
            this.Name = "MATHLED";
            this.Text = "MATHSOFT LED CONTROL";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.colorPickerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton typeRadioSolid;
        private System.Windows.Forms.RadioButton typeRadioPulse;
        private System.Windows.Forms.RadioButton typeRadioRainbow;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton powerRadioOn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton powerRadioOff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button toggleConnectionButton;
        private System.Windows.Forms.Panel colorPickerPanel;
        private HSVColorPicker colorPicker;
        private System.Windows.Forms.Button button1;
    }
}

