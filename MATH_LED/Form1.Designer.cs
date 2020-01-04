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
            this.tableLayoutPanel_Programs = new System.Windows.Forms.TableLayoutPanel();
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
            this.label_Delta = new System.Windows.Forms.Label();
            this.label_Delay = new System.Windows.Forms.Label();
            this.label_Rate = new System.Windows.Forms.Label();
            this.trackBar_Rate = new System.Windows.Forms.TrackBar();
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
            this.title.Location = new System.Drawing.Point(12, 352);
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
            // tableLayoutPanel_Programs
            // 
            this.tableLayoutPanel_Programs.ColumnCount = 1;
            this.tableLayoutPanel_Programs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioSolid, 0, 0);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioPulse, 0, 2);
            this.tableLayoutPanel_Programs.Controls.Add(this.typeRadioRainbow, 0, 2);
            this.tableLayoutPanel_Programs.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_Programs.Name = "tableLayoutPanel_Programs";
            this.tableLayoutPanel_Programs.RowCount = 3;
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Programs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Programs.Size = new System.Drawing.Size(158, 69);
            this.tableLayoutPanel_Programs.TabIndex = 15;
            // 
            // tableLayoutPanel_Power
            // 
            this.tableLayoutPanel_Power.ColumnCount = 1;
            this.tableLayoutPanel_Power.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Power.Controls.Add(this.powerRadioOn, 0, 0);
            this.tableLayoutPanel_Power.Controls.Add(this.powerRadioOff, 0, 1);
            this.tableLayoutPanel_Power.Location = new System.Drawing.Point(538, 12);
            this.tableLayoutPanel_Power.Name = "tableLayoutPanel_Power";
            this.tableLayoutPanel_Power.RowCount = 2;
            this.tableLayoutPanel_Power.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Power.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Power.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Power.Size = new System.Drawing.Size(158, 48);
            this.tableLayoutPanel_Power.TabIndex = 16;
            // 
            // flowLayoutPanel_Connect
            // 
            this.flowLayoutPanel_Connect.Controls.Add(this.portComboBox);
            this.flowLayoutPanel_Connect.Controls.Add(this.toggleConnectionButton);
            this.flowLayoutPanel_Connect.Location = new System.Drawing.Point(538, 66);
            this.flowLayoutPanel_Connect.Name = "flowLayoutPanel_Connect";
            this.flowLayoutPanel_Connect.Size = new System.Drawing.Size(158, 76);
            this.flowLayoutPanel_Connect.TabIndex = 17;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(3, 3);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(151, 21);
            this.portComboBox.TabIndex = 0;
            // 
            // toggleConnectionButton
            // 
            this.toggleConnectionButton.Location = new System.Drawing.Point(3, 30);
            this.toggleConnectionButton.Name = "toggleConnectionButton";
            this.toggleConnectionButton.Size = new System.Drawing.Size(151, 40);
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
            this.colorPickerPanel.Size = new System.Drawing.Size(353, 356);
            this.colorPickerPanel.TabIndex = 18;
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(-3, 3);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(350, 350);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.HSVColorChanged += new MATH_LED.HSVColorChangedHandler(this.colorPicker_HSVColorChanged);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(15, 326);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 19;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Clicked);
            // 
            // trackBar_Delta
            // 
            this.trackBar_Delta.Location = new System.Drawing.Point(3, 31);
            this.trackBar_Delta.Maximum = 60;
            this.trackBar_Delta.Name = "trackBar_Delta";
            this.trackBar_Delta.Size = new System.Drawing.Size(151, 37);
            this.trackBar_Delta.TabIndex = 21;
            this.trackBar_Delta.ValueChanged += new System.EventHandler(this.trackBar_Delta_ValueChanged);
            // 
            // trackBar_Delay
            // 
            this.trackBar_Delay.Location = new System.Drawing.Point(3, 102);
            this.trackBar_Delay.Maximum = 100;
            this.trackBar_Delay.Name = "trackBar_Delay";
            this.trackBar_Delay.Size = new System.Drawing.Size(151, 37);
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
            this.tableLayoutPanel_Slider.Location = new System.Drawing.Point(538, 148);
            this.tableLayoutPanel_Slider.Name = "tableLayoutPanel_Slider";
            this.tableLayoutPanel_Slider.RowCount = 6;
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel_Slider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Slider.Size = new System.Drawing.Size(158, 217);
            this.tableLayoutPanel_Slider.TabIndex = 23;
            // 
            // label_Delta
            // 
            this.label_Delta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Delta.AutoSize = true;
            this.label_Delta.Location = new System.Drawing.Point(63, 7);
            this.label_Delta.Name = "label_Delta";
            this.label_Delta.Size = new System.Drawing.Size(32, 13);
            this.label_Delta.TabIndex = 24;
            this.label_Delta.Text = "Delta";
            // 
            // label_Delay
            // 
            this.label_Delay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Delay.AutoSize = true;
            this.label_Delay.Location = new System.Drawing.Point(62, 78);
            this.label_Delay.Name = "label_Delay";
            this.label_Delay.Size = new System.Drawing.Size(34, 13);
            this.label_Delay.TabIndex = 25;
            this.label_Delay.Text = "Delay";
            // 
            // label_Rate
            // 
            this.label_Rate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Rate.AutoSize = true;
            this.label_Rate.Location = new System.Drawing.Point(43, 99);
            this.label_Rate.Name = "label_Rate";
            this.label_Rate.Size = new System.Drawing.Size(20, 9);
            this.label_Rate.TabIndex = 26;
            this.label_Rate.Text = "Rate";
            // 
            // trackBar_Rate
            // 
            this.trackBar_Rate.Location = new System.Drawing.Point(3, 173);
            this.trackBar_Rate.Maximum = 100;
            this.trackBar_Rate.Name = "trackBar_Rate";
            this.trackBar_Rate.Size = new System.Drawing.Size(151, 41);
            this.trackBar_Rate.TabIndex = 27;
            // 
            // MATHLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 372);
            this.Controls.Add(this.tableLayoutPanel_Slider);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.colorPickerPanel);
            this.Controls.Add(this.flowLayoutPanel_Connect);
            this.Controls.Add(this.tableLayoutPanel_Power);
            this.Controls.Add(this.tableLayoutPanel_Programs);
            this.Controls.Add(this.title);
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
    }
}

