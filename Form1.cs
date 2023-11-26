namespace Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("USD");
            comboBox1.Items.Add("GBP");
            comboBox1.Items.Add("AED");

            comboBox2.Items.Add("USD");
            comboBox2.Items.Add("GBP");
            comboBox2.Items.Add("AED");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();
            if (selectedOption == "USD")
            {

                int convertedUnit = int.Parse(txt_ConvertToRupees.Text);
                // MessageBox.Show($"You selected {Currency.ConvertToRupees(convertedUnit, selectedOption)}");

                display_Rs.Text = Currency.ConvertToRupees(convertedUnit, selectedOption).ToString("0.00");
            }
            else if (selectedOption == "GBP")
            {
                int convertedUnit = int.Parse(txt_ConvertToRupees.Text);
                display_Rs.Text = Currency.ConvertToRupees(convertedUnit, selectedOption).ToString("0.00");

            }
            else
            {
                int convertedUnit = int.Parse(txt_ConvertToRupees.Text);
                display_Rs.Text = Currency.ConvertToRupees(convertedUnit, selectedOption).ToString("0.00");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox2.SelectedItem.ToString();
            if (selectedOption == "USD")
            {

                int convertedUnit = int.Parse(convertFromRupees.Text);

                display_dollar.Text = Currency.ConvertFromRupees(convertedUnit, selectedOption).ToString("0.00");
            }
            else if (selectedOption == "GBP")
            {
                int convertedUnit = int.Parse(convertFromRupees.Text);
                display_dollar.Text = Currency.ConvertFromRupees(convertedUnit, selectedOption).ToString("0.00");

            }
            else
            {
                int convertedUnit = int.Parse(convertFromRupees.Text);
                display_dollar.Text = Currency.ConvertFromRupees(convertedUnit, selectedOption).ToString("0.00");
            }


        }
    }
}