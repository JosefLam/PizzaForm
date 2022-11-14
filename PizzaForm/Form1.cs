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
            MargheritaCL pizza = new MargheritaCL();
            lbl_out.Text = ($"{pizza.name} cheese:{pizza.cheese}, tomato:{pizza.tomato}, sausage:{pizza.sausage}");
        }
        private void pepperoniBTN_Click(object sender, EventArgs e)
        {
            PepperoniCL pizza = new PepperoniCL();
            lbl_out.Text = ($"{pizza.name} cheese:{pizza.cheese}, tomato:{pizza.tomato}, sausage:{pizza.sausage}");
        }


        class pizza
        {
            public string name = "testpizza";
            public bool tomato = true;
            public bool cheese = true;
            public bool sausage = false;
        }

        class MargheritaCL: pizza
        {
            public MargheritaCL()
            {
                name = ("margherita");
            }
            
        }

        class PepperoniCL: pizza
        {
            public PepperoniCL()
            {
                name = ("pepperoni");
                sausage = true;
            }
            
        }

        
    }
}