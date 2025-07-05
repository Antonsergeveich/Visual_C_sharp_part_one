namespace CallTrackerApp
{
	partial class MainForm
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
			this.btnOrder = new System.Windows.Forms.Button();
			this.btnThinking = new System.Windows.Forms.Button();
			this.btnReject = new System.Windows.Forms.Button();
			this.lblThinking = new System.Windows.Forms.Label();
			this.lblReject = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.btnShowChart = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblDateRange = new System.Windows.Forms.Label();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.lblOrder = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOrder
			// 
			this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOrder.Location = new System.Drawing.Point(24, 23);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(116, 35);
			this.btnOrder.TabIndex = 0;
			this.btnOrder.Text = "Заказал";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// btnThinking
			// 
			this.btnThinking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnThinking.Location = new System.Drawing.Point(24, 84);
			this.btnThinking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThinking.Name = "btnThinking";
			this.btnThinking.Size = new System.Drawing.Size(116, 35);
			this.btnThinking.TabIndex = 1;
			this.btnThinking.Text = "Думает";
			this.btnThinking.UseVisualStyleBackColor = true;
			this.btnThinking.Click += new System.EventHandler(this.btnThinking_Click);
			// 
			// btnReject
			// 
			this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnReject.Location = new System.Drawing.Point(24, 148);
			this.btnReject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnReject.Name = "btnReject";
			this.btnReject.Size = new System.Drawing.Size(116, 35);
			this.btnReject.TabIndex = 2;
			this.btnReject.Text = "Отказ";
			this.btnReject.UseVisualStyleBackColor = true;
			this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
			// 
			// lblThinking
			// 
			this.lblThinking.AutoSize = true;
			this.lblThinking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblThinking.Location = new System.Drawing.Point(164, 90);
			this.lblThinking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblThinking.Name = "lblThinking";
			this.lblThinking.Size = new System.Drawing.Size(112, 25);
			this.lblThinking.TabIndex = 4;
			this.lblThinking.Text = "Думает: 0";
			// 
			// lblReject
			// 
			this.lblReject.AutoSize = true;
			this.lblReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblReject.Location = new System.Drawing.Point(164, 148);
			this.lblReject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblReject.Name = "lblReject";
			this.lblReject.Size = new System.Drawing.Size(96, 25);
			this.lblReject.TabIndex = 5;
			this.lblReject.Text = "Отказ: 0";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(24, 270);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(192, 35);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(24, 330);
			this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 7;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// btnShowChart
			// 
			this.btnShowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnShowChart.Location = new System.Drawing.Point(326, 70);
			this.btnShowChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShowChart.Name = "btnShowChart";
			this.btnShowChart.Size = new System.Drawing.Size(556, 45);
			this.btnShowChart.TabIndex = 9;
			this.btnShowChart.Text = "Показать график";
			this.btnShowChart.UseVisualStyleBackColor = true;
			this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(326, 122);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1056, 396);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// lblDateRange
			// 
			this.lblDateRange.AutoSize = true;
			this.lblDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDateRange.Location = new System.Drawing.Point(319, 28);
			this.lblDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDateRange.Name = "lblDateRange";
			this.lblDateRange.Size = new System.Drawing.Size(288, 25);
			this.lblDateRange.TabIndex = 11;
			this.lblDateRange.Text = "Диапазон дат для графика:";
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartDate.Location = new System.Drawing.Point(907, 70);
			this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(212, 38);
			this.dtpStartDate.TabIndex = 12;
			this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndDate.Location = new System.Drawing.Point(1166, 71);
			this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(216, 38);
			this.dtpEndDate.TabIndex = 13;
			this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
			// 
			// lblOrder
			// 
			this.lblOrder.AutoSize = true;
			this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblOrder.Location = new System.Drawing.Point(164, 33);
			this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOrder.Name = "lblOrder";
			this.lblOrder.Size = new System.Drawing.Size(119, 25);
			this.lblOrder.TabIndex = 3;
			this.lblOrder.Text = "Заказал: 0";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnReset.Location = new System.Drawing.Point(24, 208);
			this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(116, 35);
			this.btnReset.TabIndex = 14;
			this.btnReset.Text = "Сбросить";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1407, 535);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.lblDateRange);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnShowChart);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblReject);
			this.Controls.Add(this.lblThinking);
			this.Controls.Add(this.lblOrder);
			this.Controls.Add(this.btnReject);
			this.Controls.Add(this.btnThinking);
			this.Controls.Add(this.btnOrder);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Автовыкуп";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Button btnThinking;
		private System.Windows.Forms.Button btnReject;
		private System.Windows.Forms.Label lblThinking;
		private System.Windows.Forms.Label lblReject;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button btnShowChart;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblDateRange;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Label lblOrder;
		private System.Windows.Forms.Button btnReset;
	}
}