namespace DESCryptoServiceProviderFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length != 8)
                {
                    MessageBox.Show("key값을 8자리로 맞춰주세요.");
                    return;
                }

                DES des = new DES(textBox1.Text);

                DES.DesType type = radioButton1.Checked ? DES.DesType.Encrypt : DES.DesType.Decrypt;

                textBox3.Text = des.result(type, textBox2.Text);
            }
        }
    }



}