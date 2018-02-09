using System.Windows.Forms;

namespace CommandLineParametersCatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string[] args) : this()
        {
            textBox.Text = string.Join(" ", args);
        }
    }
}