namespace Homework2
{
	public partial class frmInvoiceTotal : Form
	{
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e) { }

		private void label3_Click(object sender, EventArgs e) { }

		private void textBox1_TextChanged(object sender, EventArgs e) { }

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Decimal.Parse(txtSubtotal.Text);
			string customerType = txtCustomerType.Text.Trim().ToUpper();

			decimal discountPercent = customerType switch
			{
				"R" => 0.30m,
				"C" => 0.20m,
				"T" => 0.50m,
				_ => 0.10m
			};

			decimal discountAmount = subtotal * discountPercent;
			decimal invoiceTotal = subtotal - discountAmount;

			discountAmount = Math.Round(discountAmount, 2);
			invoiceTotal = Math.Round(invoiceTotal, 2);

			txtDiscountPercent.Text = discountPercent.ToString("p0");
			txtDiscountAmount.Text = discountAmount.ToString("C");
			txtTotal.Text = invoiceTotal.ToString("C");
		}
	}
}
