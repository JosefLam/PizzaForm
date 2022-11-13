using System.Xml.Linq;

namespace PizzaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void margheritaBTN_Click(object sender, EventArgs e)
        {
            margheritaCL pizza = new margheritaCL();
            list = ($"{list} {name}");
            lbl_out.Text = list;
        }
        private void pepperoniBTN_Click(object sender, EventArgs e)
        {
            pepperoniCL pizza = new pepperoniCL();
            list = ($"{list} {name}");
            lbl_out.Text = list;
        }

        string list;

        class pizza
        {
            private string name;
            private bool tomato = true;
            private bool cheese = true;
            private bool sausage = false;
        }

        class margheritaCL: pizza
        {
            name = ("margherita");
        }

        class pepperoniCL: pizza
        {
            name = ("pepperoni");
            sausage = true;
        }

        
    }
}