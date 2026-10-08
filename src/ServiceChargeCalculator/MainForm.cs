namespace ServiceChargeCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // --- Xử lý nút "Tính tiền" ---
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate đơn giá
            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Vui lòng nhập Đơn giá hợp lệ (số dương).", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return;
            }

            // Validate số lượng khách
            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Vui lòng nhập Số lượng khách hợp lệ (số nguyên dương).", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Validate mã giảm giá (0–100)
            if (!decimal.TryParse(txtDiscount.Text.Trim(), out decimal discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Vui lòng nhập % Giảm giá hợp lệ (0 đến 100).", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }

            // Tính: Tổng = (Đơn giá × Số lượng) × (100 - % Giảm) / 100
            decimal total = (unitPrice * quantity) * (100 - discount) / 100;
            lblResult.Text = $"Tổng tiền thanh toán: {total:N0} VNĐ";
        }

        // --- Xử lý nút "Làm mới" ---
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtDiscount.Text = "0";
            lblResult.Text = "Tổng tiền thanh toán: ---";
            txtUnitPrice.Focus();
        }
    }
}
