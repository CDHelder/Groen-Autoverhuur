namespace Groen__Autoverhuur
{
    partial class Form1
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.hoofdtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPassengerCar = new System.Windows.Forms.RadioButton();
            this.rbPassengerBus = new System.Windows.Forms.RadioButton();
            this.nudAmountKm = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bCalculate = new System.Windows.Forms.Button();
            this.labelRentalPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountKm)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(18, 76);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(330, 29);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(18, 138);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(330, 29);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // hoofdtext
            // 
            this.hoofdtext.AutoSize = true;
            this.hoofdtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoofdtext.Location = new System.Drawing.Point(13, 13);
            this.hoofdtext.Name = "hoofdtext";
            this.hoofdtext.Size = new System.Drawing.Size(351, 25);
            this.hoofdtext.TabIndex = 2;
            this.hoofdtext.Text = "Enter the start and end of the rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "End date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the type of car";
            // 
            // rbPassengerCar
            // 
            this.rbPassengerCar.AutoSize = true;
            this.rbPassengerCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassengerCar.Location = new System.Drawing.Point(18, 227);
            this.rbPassengerCar.Name = "rbPassengerCar";
            this.rbPassengerCar.Size = new System.Drawing.Size(129, 24);
            this.rbPassengerCar.TabIndex = 6;
            this.rbPassengerCar.TabStop = true;
            this.rbPassengerCar.Text = "Passenger car";
            this.rbPassengerCar.UseVisualStyleBackColor = true;
            // 
            // rbPassengerBus
            // 
            this.rbPassengerBus.AutoSize = true;
            this.rbPassengerBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassengerBus.Location = new System.Drawing.Point(229, 227);
            this.rbPassengerBus.Name = "rbPassengerBus";
            this.rbPassengerBus.Size = new System.Drawing.Size(133, 24);
            this.rbPassengerBus.TabIndex = 7;
            this.rbPassengerBus.TabStop = true;
            this.rbPassengerBus.Text = "Passenger bus";
            this.rbPassengerBus.UseVisualStyleBackColor = true;
            // 
            // nudAmountKm
            // 
            this.nudAmountKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmountKm.Location = new System.Drawing.Point(18, 301);
            this.nudAmountKm.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAmountKm.Name = "nudAmountKm";
            this.nudAmountKm.Size = new System.Drawing.Size(120, 29);
            this.nudAmountKm.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter the amount of km";
            // 
            // bCalculate
            // 
            this.bCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculate.Location = new System.Drawing.Point(18, 352);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(107, 33);
            this.bCalculate.TabIndex = 10;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // labelRentalPrice
            // 
            this.labelRentalPrice.AutoSize = true;
            this.labelRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalPrice.Location = new System.Drawing.Point(13, 403);
            this.labelRentalPrice.Name = "labelRentalPrice";
            this.labelRentalPrice.Size = new System.Drawing.Size(133, 25);
            this.labelRentalPrice.TabIndex = 11;
            this.labelRentalPrice.Text = "Rental price:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(152, 403);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(82, 25);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "XXXXX";
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(241, 352);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(107, 33);
            this.bReset.TabIndex = 13;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 463);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRentalPrice);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAmountKm);
            this.Controls.Add(this.rbPassengerBus);
            this.Controls.Add(this.rbPassengerCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoofdtext);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label hoofdtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPassengerCar;
        private System.Windows.Forms.RadioButton rbPassengerBus;
        private System.Windows.Forms.NumericUpDown nudAmountKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Label labelRentalPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button bReset;
    }
}

