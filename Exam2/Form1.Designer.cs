namespace Exam2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtSeatFare = new System.Windows.Forms.TextBox();
            this.txtFarePerKg = new System.Windows.Forms.TextBox();
            this.txtNoOfSeats = new System.Windows.Forms.TextBox();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.txtTotalSeatFare = new System.Windows.Forms.TextBox();
            this.txtTotalLuggFare = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK YOR TICKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation Id:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seat Fare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fare per Kg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "NO of Seats:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Weight Kg:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Seat Fare $:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Luggage Fair $:";
            // 
            // txtResId
            // 
            this.txtResId.Location = new System.Drawing.Point(262, 68);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(178, 22);
            this.txtResId.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(262, 116);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(178, 22);
            this.txtCustomerName.TabIndex = 11;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(262, 168);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(178, 22);
            this.txtContactNo.TabIndex = 12;
            // 
            // txtSeatFare
            // 
            this.txtSeatFare.Location = new System.Drawing.Point(262, 210);
            this.txtSeatFare.Name = "txtSeatFare";
            this.txtSeatFare.ReadOnly = true;
            this.txtSeatFare.Size = new System.Drawing.Size(178, 22);
            this.txtSeatFare.TabIndex = 13;
            // 
            // txtFarePerKg
            // 
            this.txtFarePerKg.Location = new System.Drawing.Point(262, 257);
            this.txtFarePerKg.Name = "txtFarePerKg";
            this.txtFarePerKg.ReadOnly = true;
            this.txtFarePerKg.Size = new System.Drawing.Size(178, 22);
            this.txtFarePerKg.TabIndex = 14;
            this.txtFarePerKg.TextChanged += new System.EventHandler(this.txtFarePerKg_TextChanged);
            // 
            // txtNoOfSeats
            // 
            this.txtNoOfSeats.Location = new System.Drawing.Point(262, 289);
            this.txtNoOfSeats.Name = "txtNoOfSeats";
            this.txtNoOfSeats.Size = new System.Drawing.Size(178, 22);
            this.txtNoOfSeats.TabIndex = 15;
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Location = new System.Drawing.Point(262, 333);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(178, 22);
            this.txtTotalWeight.TabIndex = 16;
            // 
            // txtTotalSeatFare
            // 
            this.txtTotalSeatFare.Location = new System.Drawing.Point(262, 377);
            this.txtTotalSeatFare.Name = "txtTotalSeatFare";
            this.txtTotalSeatFare.ReadOnly = true;
            this.txtTotalSeatFare.Size = new System.Drawing.Size(178, 22);
            this.txtTotalSeatFare.TabIndex = 17;
            // 
            // txtTotalLuggFare
            // 
            this.txtTotalLuggFare.Location = new System.Drawing.Point(262, 425);
            this.txtTotalLuggFare.Name = "txtTotalLuggFare";
            this.txtTotalLuggFare.ReadOnly = true;
            this.txtTotalLuggFare.Size = new System.Drawing.Size(178, 22);
            this.txtTotalLuggFare.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Total Fare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalLuggFare);
            this.Controls.Add(this.txtTotalSeatFare);
            this.Controls.Add(this.txtTotalWeight);
            this.Controls.Add(this.txtNoOfSeats);
            this.Controls.Add(this.txtFarePerKg);
            this.Controls.Add(this.txtSeatFare);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtResId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtSeatFare;
        private System.Windows.Forms.TextBox txtFarePerKg;
        private System.Windows.Forms.TextBox txtNoOfSeats;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.TextBox txtTotalSeatFare;
        private System.Windows.Forms.TextBox txtTotalLuggFare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

