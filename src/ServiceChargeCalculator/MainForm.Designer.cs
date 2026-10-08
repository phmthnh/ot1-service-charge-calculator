namespace ServiceChargeCalculator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUnitPrice    = new System.Windows.Forms.Label();
            this.txtUnitPrice    = new System.Windows.Forms.TextBox();
            this.lblQuantity     = new System.Windows.Forms.Label();
            this.txtQuantity     = new System.Windows.Forms.TextBox();
            this.lblDiscount     = new System.Windows.Forms.Label();
            this.txtDiscount     = new System.Windows.Forms.TextBox();
            this.lblResult       = new System.Windows.Forms.Label();
            this.btnCalculate    = new System.Windows.Forms.Button();
            this.btnReset        = new System.Windows.Forms.Button();
            this.grpInput        = new System.Windows.Forms.GroupBox();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();

            // grpInput
            this.grpInput.Controls.Add(this.lblUnitPrice);
            this.grpInput.Controls.Add(this.txtUnitPrice);
            this.grpInput.Controls.Add(this.lblQuantity);
            this.grpInput.Controls.Add(this.txtQuantity);
            this.grpInput.Controls.Add(this.lblDiscount);
            this.grpInput.Controls.Add(this.txtDiscount);
            this.grpInput.Controls.Add(this.lblResult);
            this.grpInput.Controls.Add(this.btnCalculate);
            this.grpInput.Controls.Add(this.btnReset);
            this.grpInput.Location = new System.Drawing.Point(20, 15);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(400, 280);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin dịch vụ";

            // lblUnitPrice
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(15, 35);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(100, 15);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "Đơn giá dịch vụ:";

            // txtUnitPrice
            this.txtUnitPrice.Location = new System.Drawing.Point(180, 32);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(190, 23);
            this.txtUnitPrice.TabIndex = 1;

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(15, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(110, 15);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Số lượng khách:";

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(180, 72);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(190, 23);
            this.txtQuantity.TabIndex = 3;

            // lblDiscount
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(15, 115);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(110, 15);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "% Giảm giá (0-100):";

            // txtDiscount
            this.txtDiscount.Location = new System.Drawing.Point(180, 112);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(190, 23);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0";

            // lblResult
            this.lblResult.AutoSize = false;
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResult.Location = new System.Drawing.Point(15, 155);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(355, 40);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Tổng tiền thanh toán: ---";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnCalculate
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 215);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Tính tiền";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnReset
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(250, 215);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.grpInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT1 - Máy tính tính cước dịch vụ & Giảm giá";

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpInput;
    }
}
