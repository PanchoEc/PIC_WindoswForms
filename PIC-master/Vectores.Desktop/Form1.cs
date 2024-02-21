using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vectores.Desktop
{
    public partial class Form1 : Form
    {
        Vector vectorA = new Vector();
        Vector vectorB = new Vector();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveReg_Click(object sender, EventArgs e)
        {
            double X1, Y1, Z1, X2, Y2, Z2;

            if (!Double.TryParse(txtX1.Text, out X1))
            {
                error1.SetError(txtX1, "Debe ingresar un número");
                txtX1.Focus();
                return;
            }
            error1.SetError(txtX1, "");

            if (!Double.TryParse(txtY1.Text, out Y1))
            {
                error1.SetError(txtY1, "Debe ingresar un número");
                txtY1.Focus();
                return;
            }
            error1.SetError(txtY1, "");

            if (!Double.TryParse(txtZ1.Text, out Z1))
            {
                error1.SetError(txtZ1, "Debe ingresar un número");
                txtZ1.Focus();
                return;
            }
            error1.SetError(txtZ1, "");

            if (!Double.TryParse(txtX2.Text, out X2))
            {
                error1.SetError(txtX2, "Debe ingresar un número");
                txtX2.Focus();
                return;
            }
            error1.SetError(txtX2, "");

            if (!Double.TryParse(txtY2.Text, out Y2))
            {
                error1.SetError(txtY2, "Debe ingresar un número");
                txtY2.Focus();
                return;
            }
            error1.SetError(txtY2, "");

            if (!Double.TryParse(txtZ2.Text, out Z2))
            {
                error1.SetError(txtZ2, "Debe ingresar un número");
                txtZ2.Focus();
                return;
            }
            error1.SetError(txtZ2, "");

            vectorA.X = Convert.ToDouble(txtX1.Text);
            vectorA.Y = Convert.ToDouble(txtY1.Text);
            vectorA.Z = Convert.ToDouble(txtZ1.Text);
            vectorB.X = Convert.ToDouble(txtX2.Text);
            vectorB.Y = Convert.ToDouble(txtY2.Text);
            vectorB.Z = Convert.ToDouble(txtZ2.Text);

            MessageBox.Show("Los datos de los vectores A y B están correctos");

            txtAdd.Text = "(" + Convert.ToString(Math.Round((vectorA.X + vectorB.X), 3)) + ", " + Convert.ToString(Math.Round((vectorA.Y + vectorB.Y), 3))
             + ", " + Convert.ToString(Math.Round((vectorA.Z + vectorB.Z), 3)) + ")";

            txtSubstract.Text = "(" + Convert.ToString(Math.Round((vectorA.X - vectorB.X), 3)) + ", " + Convert.ToString(Math.Round((vectorA.Y - vectorB.Y), 3))
             + ", " + Convert.ToString(Math.Round((vectorA.Z - vectorB.Z), 3)) + ")";

            txtPointProduct.Text = "(" + Convert.ToString(Math.Round((vectorA.X * vectorB.X), 3)) + ", " + Convert.ToString(Math.Round((vectorA.Y * vectorB.Y), 3))
             + ", " + Convert.ToString(Math.Round((vectorA.Z * vectorB.Z), 3)) + ") = " + (Math.Round((vectorA.X * vectorB.X), 3) + Math.Round((vectorA.Y * vectorB.Y), 3) + Math.Round((vectorA.Z * vectorB.Z), 3));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtY1.Clear();
            txtZ1.Clear();
            txtX2.Clear();
            txtY2.Clear();
            txtZ2.Clear();
            txtAdd.Clear();
            txtSubstract.Clear();
            txtPointProduct.Clear();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A + B = (xa + xb, ya + yb, za + zb)");
        }

        private void pictureBoxSubstract_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A - B = (xa - xb, ya - yb, za - zb)");
        }

        private void pictureBoxPointProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A * B = (xa * xb + ya * yb + za * zb)");
        }
    }
}

