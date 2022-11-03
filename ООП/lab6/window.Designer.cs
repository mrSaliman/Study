namespace lab6
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.httpLabel = new System.Windows.Forms.NumericUpDown();
            this.iptvLabel = new System.Windows.Forms.NumericUpDown();
            this.torrentLabel = new System.Windows.Forms.NumericUpDown();
            this.ftpLabel = new System.Windows.Forms.NumericUpDown();
            this.wholeWindow = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setLabel = new System.Windows.Forms.Label();
            this.outputData = new System.Windows.Forms.SplitContainer();
            this.traficView = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.averageDatePicker = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.httpLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iptvLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torrentLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftpLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeWindow)).BeginInit();
            this.wholeWindow.Panel1.SuspendLayout();
            this.wholeWindow.Panel2.SuspendLayout();
            this.wholeWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputData)).BeginInit();
            this.outputData.Panel1.SuspendLayout();
            this.outputData.Panel2.SuspendLayout();
            this.outputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 61);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(222, 23);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.UpdateWindow);
            this.dateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Window_KeyPress);
            // 
            // httpLabel
            // 
            this.httpLabel.InterceptArrowKeys = false;
            this.httpLabel.Location = new System.Drawing.Point(70, 108);
            this.httpLabel.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.httpLabel.Name = "httpLabel";
            this.httpLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.httpLabel.Size = new System.Drawing.Size(94, 23);
            this.httpLabel.TabIndex = 2;
            this.httpLabel.ThousandsSeparator = true;
            this.httpLabel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.httpLabel.Enter += new System.EventHandler(this.HttpLabel_Enter);
            this.httpLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Window_KeyPress);
            // 
            // iptvLabel
            // 
            this.iptvLabel.InterceptArrowKeys = false;
            this.iptvLabel.Location = new System.Drawing.Point(70, 137);
            this.iptvLabel.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.iptvLabel.Name = "iptvLabel";
            this.iptvLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iptvLabel.Size = new System.Drawing.Size(94, 23);
            this.iptvLabel.TabIndex = 3;
            this.iptvLabel.ThousandsSeparator = true;
            this.iptvLabel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.iptvLabel.Enter += new System.EventHandler(this.HttpLabel_Enter);
            this.iptvLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Window_KeyPress);
            // 
            // torrentLabel
            // 
            this.torrentLabel.InterceptArrowKeys = false;
            this.torrentLabel.Location = new System.Drawing.Point(70, 166);
            this.torrentLabel.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.torrentLabel.Name = "torrentLabel";
            this.torrentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.torrentLabel.Size = new System.Drawing.Size(94, 23);
            this.torrentLabel.TabIndex = 4;
            this.torrentLabel.ThousandsSeparator = true;
            this.torrentLabel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.torrentLabel.Enter += new System.EventHandler(this.HttpLabel_Enter);
            this.torrentLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Window_KeyPress);
            // 
            // ftpLabel
            // 
            this.ftpLabel.InterceptArrowKeys = false;
            this.ftpLabel.Location = new System.Drawing.Point(70, 195);
            this.ftpLabel.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ftpLabel.Name = "ftpLabel";
            this.ftpLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ftpLabel.Size = new System.Drawing.Size(94, 23);
            this.ftpLabel.TabIndex = 5;
            this.ftpLabel.ThousandsSeparator = true;
            this.ftpLabel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ftpLabel.Enter += new System.EventHandler(this.HttpLabel_Enter);
            this.ftpLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Window_KeyPress);
            // 
            // wholeWindow
            // 
            this.wholeWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wholeWindow.IsSplitterFixed = true;
            this.wholeWindow.Location = new System.Drawing.Point(0, 0);
            this.wholeWindow.Name = "wholeWindow";
            // 
            // wholeWindow.Panel1
            // 
            this.wholeWindow.Panel1.Controls.Add(this.label4);
            this.wholeWindow.Panel1.Controls.Add(this.label3);
            this.wholeWindow.Panel1.Controls.Add(this.label2);
            this.wholeWindow.Panel1.Controls.Add(this.label1);
            this.wholeWindow.Panel1.Controls.Add(this.setLabel);
            this.wholeWindow.Panel1.Controls.Add(this.httpLabel);
            this.wholeWindow.Panel1.Controls.Add(this.ftpLabel);
            this.wholeWindow.Panel1.Controls.Add(this.dateTimePicker);
            this.wholeWindow.Panel1.Controls.Add(this.torrentLabel);
            this.wholeWindow.Panel1.Controls.Add(this.iptvLabel);
            // 
            // wholeWindow.Panel2
            // 
            this.wholeWindow.Panel2.Controls.Add(this.outputData);
            this.wholeWindow.Size = new System.Drawing.Size(584, 321);
            this.wholeWindow.SplitterDistance = 250;
            this.wholeWindow.TabIndex = 0;
            this.wholeWindow.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "FTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Torrent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP-TV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "HTTP";
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setLabel.Location = new System.Drawing.Point(20, 9);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(144, 30);
            this.setLabel.TabIndex = 0;
            this.setLabel.Text = "Ввод данных";
            // 
            // outputData
            // 
            this.outputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputData.IsSplitterFixed = true;
            this.outputData.Location = new System.Drawing.Point(0, 0);
            this.outputData.Name = "outputData";
            this.outputData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // outputData.Panel1
            // 
            this.outputData.Panel1.Controls.Add(this.traficView);
            // 
            // outputData.Panel2
            // 
            this.outputData.Panel2.Controls.Add(this.label5);
            this.outputData.Panel2.Controls.Add(this.averageDatePicker);
            this.outputData.Size = new System.Drawing.Size(330, 321);
            this.outputData.SplitterDistance = 84;
            this.outputData.TabIndex = 2;
            this.outputData.TabStop = false;
            // 
            // traficView
            // 
            this.traficView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.traficView.Location = new System.Drawing.Point(0, 0);
            this.traficView.Multiline = true;
            this.traficView.Name = "traficView";
            this.traficView.ReadOnly = true;
            this.traficView.Size = new System.Drawing.Size(329, 84);
            this.traficView.TabIndex = 0;
            this.traficView.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Обзор данных";
            // 
            // averageDatePicker
            // 
            this.averageDatePicker.Location = new System.Drawing.Point(9, 50);
            this.averageDatePicker.MaxSelectionCount = 100000;
            this.averageDatePicker.Name = "averageDatePicker";
            this.averageDatePicker.TabIndex = 1;
            this.averageDatePicker.TabStop = false;
            this.averageDatePicker.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.averageDatePicker_DateSelected);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.wholeWindow);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 360);
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab6";
            ((System.ComponentModel.ISupportInitialize)(this.httpLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iptvLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torrentLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftpLabel)).EndInit();
            this.wholeWindow.Panel1.ResumeLayout(false);
            this.wholeWindow.Panel1.PerformLayout();
            this.wholeWindow.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wholeWindow)).EndInit();
            this.wholeWindow.ResumeLayout(false);
            this.outputData.Panel1.ResumeLayout(false);
            this.outputData.Panel1.PerformLayout();
            this.outputData.Panel2.ResumeLayout(false);
            this.outputData.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputData)).EndInit();
            this.outputData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dateTimePicker;
        private NumericUpDown httpLabel;
        private NumericUpDown iptvLabel;
        private NumericUpDown torrentLabel;
        private NumericUpDown ftpLabel;
        private SplitContainer wholeWindow;
        private MonthCalendar averageDatePicker;
        private SplitContainer outputData;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label setLabel;
        private TextBox traficView;
        private Label label5;
    }
}