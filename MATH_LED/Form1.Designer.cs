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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MATHLED));
            this.typeRadioSolid = new System.Windows.Forms.RadioButton();
            this.typeRadioPulse = new System.Windows.Forms.RadioButton();
            this.typeRadioRainbow = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            this.powerRadioOn = new System.Windows.Forms.RadioButton();
            this.powerRadioOff = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel_Programs = new System.Windows.Forms.TableLayoutPanel();
            this.typeRadioFire = new System.Windows.Forms.RadioButton();
            this.typeRadioDot = new System.Windows.Forms.RadioButton();
            this.typeRadioPlasma = new System.Windows.Forms.RadioButton();
            this.typeRadioTwinkle = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel_Power = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_Connect = new System.Windows.Forms.FlowLayoutPanel();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.toggleConnectionButton = new System.Windows.Forms.Button();
            this.colorPickerPanel = new System.Windows.Forms.Panel();
            this.colorPicker = new MATH_LED.HSVColorPicker();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.trackBar_Delta = new System.Windows.Forms.TrackBar();
            this.trackBar_Delay = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel_Slider = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar_Rate = new System.Windows.Forms.TrackBar();
            this.label_Rate = new System.Windows.Forms.Label();
            this.label_Delta = new System.Windows.Forms.Label();
            this.label_Delay = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Programs.SuspendLayout();
            this.tableLayoutPanel_Power.SuspendLayout();
            this.flowLayoutPanel_Connect.SuspendLayout();
            this.colorPickerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Delta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Delay)).BeginInit();
            this.tableLayoutPanel_Slider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // typeRadioSolid
            // 
            this.typeRadioSolid.AutoSize = true;
            this.typeRadioSolid.Location = new System.Drawing.Point(4, 5);
            this.typeRadioSolid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeRadioSolid.Name = "typeRadioSolid";
            this.typeRadioSolid.Size = new System.Drawing.Size(69, 24);
            this.typeRadioSolid.TabIndex = 0;
            this.typeRadioSolid.TabStop = true;
            this.typeRadioSolid.Text = "Solid";
            this.typeRadioSolid.UseVisualStyleBackColor = true;
            this.typeRadioSolid.CheckedChanged += new System.EventHandler(this.typeRadioSolid_CheckedChanged);
            // 
            // typeRadioPulse
            // 
            this.typeRadioPulse.AutoSize = true;
            this.typeRadioPulse.Location = new System.Drawing.Point(4, 73);
            this.typeRadioPulse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeRadioPulse.Name = "typeRadioPulse";
            this.typeRadioPulse.Size = new System.Drawing.Size(73, 24);
            this.typeRadioPulse.TabIndex = 1;
            this.typeRadioPulse.TabStop = true;
            this.typeRadioPulse.Text = "Pulse";
            this.typeRadioPulse.UseVisualStyleBackColor = true;
            this.typeRadioPulse.CheckedChanged += new System.EventHandler(this.typeRadioPulse_CheckedChanged);
            // 
            // typeRadioRainbow
            // 
            this.typeRadioRainbow.AutoSize = true;
            this.typeRadioRainbow.Location = new System.Drawing.Point(4, 39);
            this.typeRadioRainbow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeRadioRainbow.Name = "typeRadioRainbow";
            this.typeRadioRainbow.Size = new System.Drawing.Size(96, 24);
            this.typeRadioRainbow.TabIndex = 3;
            this.typeRadioRainbow.TabStop = true;
            this.typeRadioRainbow.Text = "Rainbow";
            this.typeRadioRainbow.UseVisualStyleBackColor = true;
            this.typeRadioRainbow.CheckedChanged += new System.EventHandler(this.typeRadioRainbow_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(18, 542);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(162, 20);
            this.title.TabIndex = 4;
            this.title.Text = "MATH LED Controller";
            // 
            // powerRadioOn
            // 
            this.powerRadioOn.AutoSize = true;
            this.powerRadioOn.Location = new System.Drawing.Point(4, 5);
            this.powerRadioOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powerRadioOn.Name = "powerRadioOn";
            this.powerRadioOn.Size = new System.Drawing.Size(55, 24);
            this.powerRadioOn.TabIndex = 13;
            this.powerRadioOn.TabStop = true;
            this.powerRadioOn.Text = "On";
            this.powerRadioOn.UseVisualStyleBackColor = true;
            this.powerRadioOn.CheckedChanged += new System.EventHandler(this.powerRadioOn_CheckedChanged);
            // 
            // powerRadioOff
            // 
            this.powerRadioOff.AutoSize = true;
            this.powerRadioOff.Location = new System.Drawing.Point(4, 39);
            this.powerRadioOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powerRadioOff.Name = "powerRadioOff";
            this.powerRadioOff.Size = new System.Drawing.Size(56, 24);
            this.powerRadioOff.TabIndex = 14;
            this.powerRadioOff.TabStop = true;
            this.powerRadioOff.Text = "Off";
            this.powerRadioOff.UseVisualStyleBackColor = true;
            this.powerRadioOff.CheckedChanged += new System.EventHandler(this.powerRadioOff_CheckedChanged);
            // 
            // tableLayoutPanel_Programs
            // 
            this.tableLayoutPanel_Programs.ColumnCount = 1;
            this.tableLayoutPanel_Programs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioFire, 0, 6);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioDot, 0, 5);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioPlasma, 0, 4);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioSolid, 0, 0);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioTwinkle, 0, 3);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioPulse, 0, 2);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioRainbow, 0, 1);
            this.tableLayoutPanel_Programs.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel_Programs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Programs.Name = "tableLayoutPanel_Programs";
            this.tableLayoutPanel_Programs.RowCount = 7;
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.Size = new System.Drawing.Size(237, 474);
            this.tableLayoutPanel_Programs.TabIndex = 15;
            // 
            // typeRadioFire
            // 
            this.typeRadioFire.AutoSize = true;
            this.typeRadioFire.Location = new System.Drawing.Point(4, 209);
            this.typeRadioFire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeRadioFire.Name = "typeRadioFire";
            this.typeRadioFire.Size = new System.Drawing.Size(61, 24);
            this.typeRadioFire.TabIndex = 24;
            this.typeRadioFire.TabStop = true;
            this.typeRadioFire.Text = "Fire";
            this.typeRadioFire.UseVisualStyleBackColor = true;
            this.typeRadioFire.CheckedChanged += new System.EventHandler(this.typeRadioFire_CheckedChanged);
            // 
            // typeRadioDot
            // 
            this.typeRadioDot.AutoSize = true;
            this.typeRadioDot.Location = new System.Drawing.Point(4, 175);
            this.typeRadioDot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeRadioDot.Name = "typeRadioDot";
            this.typeRadioDot.Size = new System.Drawing.Size(60, 24);
            this.typeRadioDot.TabIndex = 6;
            this.typeRadioDot.TabStop = true;
            this.typeRadioDot.Text = "Dot";
            this.typeRadioDot.UseVisualStyleBackColor = true;
            this.typeRadioDot.CheckedChanged += new System.EventHandler(this.typeRadioDot_CheckedChanged);
            // 
            // typeRadioPlasma
            // 
            this.typeRadioPlasma.AutoSize = true;
            this.typeRadioPlasma.Location = new System.Drawing.Point(4, 141);
            this.typeRadioPlasma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeRadioPlasma.Name = "typeRadioPlasma";
            this.typeRadioPlasma.Size = new System.Drawing.Size(86, 24);
            this.typeRadioPlasma.TabIndex = 5;
            this.typeRadioPlasma.TabStop = true;
            this.typeRadioPlasma.Text = "Plasma";
            this.typeRadioPlasma.UseVisualStyleBackColor = true;
            this.typeRadioPlasma.CheckedChanged += new System.EventHandler(this.typeRadioPlasma_CheckedChanged);
            // 
            // typeRadioTwinkle
            // 
            this.typeRadioTwinkle.AutoSize = true;
            this.typeRadioTwinkle.Location = new System.Drawing.Point(4, 107);
            this.typeRadioTwinkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeRadioTwinkle.Name = "typeRadioTwinkle";
            this.typeRadioTwinkle.Size = new System.Drawing.Size(86, 24);
            this.typeRadioTwinkle.TabIndex = 4;
            this.typeRadioTwinkle.TabStop = true;
            this.typeRadioTwinkle.Text = "Twinkle";
            this.typeRadioTwinkle.UseVisualStyleBackColor = true;
            this.typeRadioTwinkle.CheckedChanged += new System.EventHandler(this.typeRadioTwinkle_CheckedChanged);
            // 
            // tableLayoutPanel_Power
            // 
            this.tableLayoutPanel_Power.ColumnCount = 1;
            this.tableLayoutPanel_Power.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Power.Controls.Add(this.powerRadioOn, 0, 0);
            this.tableLayoutPanel_Power.Controls.Add(this.powerRadioOff, 0, 1);
            this.tableLayoutPanel_Power.Location = new System.Drawing.Point(807, 18);
            this.tableLayoutPanel_Power.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Power.Name = "tableLayoutPanel_Power";
            this.tableLayoutPanel_Power.RowCount = 2;
            this.tableLayoutPanel_Power.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Power.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Power.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel_Power.Size = new System.Drawing.Size(237, 74);
            this.tableLayoutPanel_Power.TabIndex = 16;
            // 
            // flowLayoutPanel_Connect
            // 
            this.flowLayoutPanel_Connect.Controls.Add(this.portComboBox);
            this.flowLayoutPanel_Connect.Controls.Add(this.toggleConnectionButton);
            this.flowLayoutPanel_Connect.Location = new System.Drawing.Point(807, 102);
            this.flowLayoutPanel_Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel_Connect.Name = "flowLayoutPanel_Connect";
            this.flowLayoutPanel_Connect.Size = new System.Drawing.Size(237, 117);
            this.flowLayoutPanel_Connect.TabIndex = 17;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(4, 5);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(224, 28);
            this.portComboBox.TabIndex = 0;
            // 
            // toggleConnectionButton
            // 
            this.toggleConnectionButton.Location = new System.Drawing.Point(4, 43);
            this.toggleConnectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggleConnectionButton.Name = "toggleConnectionButton";
            this.toggleConnectionButton.Size = new System.Drawing.Size(226, 62);
            this.toggleConnectionButton.TabIndex = 1;
            this.toggleConnectionButton.Text = "Connect";
            this.toggleConnectionButton.UseVisualStyleBackColor = true;
            this.toggleConnectionButton.Click += new System.EventHandler(this.toggleConnectionButton_Click);
            // 
            // colorPickerPanel
            // 
            this.colorPickerPanel.AutoSize = true;
            this.colorPickerPanel.Controls.Add(this.colorPicker);
            this.colorPickerPanel.Location = new System.Drawing.Point(268, 14);
            this.colorPickerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPickerPanel.Name = "colorPickerPanel";
            this.colorPickerPanel.Size = new System.Drawing.Size(530, 548);
            this.colorPickerPanel.TabIndex = 18;
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(-4, 5);
            this.colorPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(525, 538);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.HSVColorChanged += new MATH_LED.HSVColorChangedHandler(this.colorPicker_HSVColorChanged);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(22, 502);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(112, 35);
            this.button_Refresh.TabIndex = 19;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Clicked);
            // 
            // trackBar_Delta
            // 
            this.trackBar_Delta.Location = new System.Drawing.Point(4, 49);
            this.trackBar_Delta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_Delta.Maximum = 255;
            this.trackBar_Delta.Name = "trackBar_Delta";
            this.trackBar_Delta.Size = new System.Drawing.Size(226, 56);
            this.trackBar_Delta.TabIndex = 21;
            this.trackBar_Delta.ValueChanged += new System.EventHandler(this.trackBar_Delta_ValueChanged);
            // 
            // trackBar_Delay
            // 
            this.trackBar_Delay.Location = new System.Drawing.Point(4, 159);
            this.trackBar_Delay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_Delay.Maximum = 255;
            this.trackBar_Delay.Name = "trackBar_Delay";
            this.trackBar_Delay.Size = new System.Drawing.Size(226, 56);
            this.trackBar_Delay.TabIndex = 22;
            this.trackBar_Delay.ValueChanged += new System.EventHandler(this.trackBar_Delay_ValueChanged);
            // 
            // tableLayoutPanel_Slider
            // 
            this.tableLayoutPanel_Slider.ColumnCount = 1;
            this.tableLayoutPanel_Slider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Slider.Controls.Add(this.trackBar_Rate, 0, 5);
            this.tableLayoutPanel_Slider.Controls.Add(this.label_Rate, 0, 4);
            this.tableLayoutPanel_Slider.Controls.Add(this.label_Delta, 0, 0);
            this.tableLayoutPanel_Slider.Controls.Add(this.label_Delay, 0, 2);
            this.tableLayoutPanel_Slider.Controls.Add(this.trackBar_Delta, 0, 1);
            this.tableLayoutPanel_Slider.Controls.Add(this.trackBar_Delay, 0, 3);
            this.tableLayoutPanel_Slider.Location = new System.Drawing.Point(807, 228);
            this.tableLayoutPanel_Slider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Slider.Name = "tableLayoutPanel_Slider";
            this.tableLayoutPanel_Slider.RowCount = 6;
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Slider.Size = new System.Drawing.Size(237, 334);
            this.tableLayoutPanel_Slider.TabIndex = 23;
            // 
            // trackBar_Rate
            // 
            this.trackBar_Rate.Location = new System.Drawing.Point(4, 269);
            this.trackBar_Rate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_Rate.Maximum = 255;
            this.trackBar_Rate.Name = "trackBar_Rate";
            this.trackBar_Rate.Size = new System.Drawing.Size(226, 60);
            this.trackBar_Rate.TabIndex = 27;
            // 
            // label_Rate
            // 
            this.label_Rate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Rate.AutoSize = true;
            this.label_Rate.Location = new System.Drawing.Point(96, 232);
            this.label_Rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Rate.Name = "label_Rate";
            this.label_Rate.Size = new System.Drawing.Size(44, 20);
            this.label_Rate.TabIndex = 26;
            this.label_Rate.Text = "Rate";
            // 
            // label_Delta
            // 
            this.label_Delta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Delta.AutoSize = true;
            this.label_Delta.Location = new System.Drawing.Point(95, 12);
            this.label_Delta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Delta.Name = "label_Delta";
            this.label_Delta.Size = new System.Drawing.Size(47, 20);
            this.label_Delta.TabIndex = 24;
            this.label_Delta.Text = "Delta";
            // 
            // label_Delay
            // 
            this.label_Delay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Delay.AutoSize = true;
            this.label_Delay.Location = new System.Drawing.Point(94, 122);
            this.label_Delay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Delay.Name = "label_Delay";
            this.label_Delay.Size = new System.Drawing.Size(49, 20);
            this.label_Delay.TabIndex = 25;
            this.label_Delay.Text = "Delay";
            // 
            // MATHLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 572);
            this.Controls.Add(this.tableLayoutPanel_Slider);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.colorPickerPanel);
            this.Controls.Add(this.flowLayoutPanel_Connect);
            this.Controls.Add(this.tableLayoutPanel_Power);
            this.Controls.Add(this.tableLayoutPanel_Programs);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MATHLED";
            this.Text = "MATHSOFT LED CONTROL";
            this.tableLayoutPanel_Programs.ResumeLayout(false);
            this.tableLayoutPanel_Programs.PerformLayout();
            this.tableLayoutPanel_Power.ResumeLayout(false);
            this.tableLayoutPanel_Power.PerformLayout();
            this.flowLayoutPanel_Connect.ResumeLayout(false);
            this.colorPickerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Delta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Delay)).EndInit();
            this.tableLayoutPanel_Slider.ResumeLayout(false);
            this.tableLayoutPanel_Slider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton typeRadioSolid;
        private System.Windows.Forms.RadioButton typeRadioPulse;
        private System.Windows.Forms.RadioButton typeRadioRainbow;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton powerRadioOn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Programs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Power;
        private System.Windows.Forms.RadioButton powerRadioOff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Connect;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button toggleConnectionButton;
        private System.Windows.Forms.Panel colorPickerPanel;
        private HSVColorPicker colorPicker;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.TrackBar trackBar_Delta;
        private System.Windows.Forms.TrackBar trackBar_Delay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Slider;
        private System.Windows.Forms.Label label_Delta;
        private System.Windows.Forms.Label label_Delay;
        private System.Windows.Forms.TrackBar trackBar_Rate;
        private System.Windows.Forms.Label label_Rate;
        private System.Windows.Forms.RadioButton typeRadioFire;
        private System.Windows.Forms.RadioButton typeRadioDot;
        private System.Windows.Forms.RadioButton typeRadioPlasma;
        private System.Windows.Forms.RadioButton typeRadioTwinkle;
    }
}

