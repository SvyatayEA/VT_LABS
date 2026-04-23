namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onPlusCLick(object sender, EventArgs e)
        {
           /* for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                if (!char.IsDigit(textBox1.Text, i))
                {
                    label4.Text = $"'{textBox1.Text}' - не €вл€етс€ числом";
                    label4.ForeColor = Color.Red;
                }
            }

            for (int i = 0; i < textBox2.Text.Length - 1; i++)
            {
                if (!char.IsDigit(textBox2.Text, i))
                {
                    label4.Text = $"'{textBox2.Text}' - не €вл€етс€ числом";
                    label4.ForeColor = Color.Red;
                }
            }*/




            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "¬ведите число";
                label4.ForeColor = Color.Red;
            }


            else
            {
                int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                label4.Text = sum.ToString();
            }
                
            
        }

        private void onMinusClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "¬ведите число";
                label4.ForeColor = Color.Red;
            }
            else
            {
                int min = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                label4.Text = min.ToString();
            }
        }

        private void onMultiplyClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "¬ведите число";
                label4.ForeColor = Color.Red;
            }
            else
            {
                int multiply = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                label4.Text = multiply.ToString();
            }
                

        }

        private void onDivideClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "¬ведите число";
                label4.ForeColor = Color.Red;
            }
            else if (int.Parse(textBox2.Text) == 0)
            {
                label4.Text = "ƒелить на ноль нельз€";
                label4.ForeColor = Color.Red;
            }

            else 
            {
                int divide = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                label4.Text = divide.ToString();
            }
                                     
        }

        private void onClearClick(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label4.Text = "0";
            label4.ForeColor = Color.Green;
        }
    }
}
