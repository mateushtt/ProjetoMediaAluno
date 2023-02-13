namespace MediaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2, Trabalho;

            Nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(cboPesoNota1.Text);
            Nota2 = Convert.ToDouble(txtNota2.Text) * Convert.ToDouble(cboPesoNota2.Text);
            Trabalho = Convert.ToDouble(txtTrabalho.Text) * Convert.ToDouble(cboPesoTrabalho.Text);

            double Media = Nota1 + Nota2 + Trabalho;

            txtMediaFinal.Text = Media.ToString();

            double QdeAulas, QdeFaltas;

            QdeAulas = Convert.ToDouble(txtAulas.Text);
            QdeFaltas = Convert.ToDouble(txtFaltas.Text);

            double PorcentagemPresenca = 100 - ((QdeFaltas / QdeAulas) * 100);

            txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";

            if(txtRecuperacao.Text == "")
            {
                if(Media >= Convert.ToDouble(numNotaCorte.Value) && PorcentagemPresenca >= 75)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }

                else
                    if(Media <= 2.5 || PorcentagemPresenca < 75)
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Red; 
                }

                else
                {
                    lblSituacao.Text = "Recuperação";
                    lblSituacao.ForeColor = Color.Red;
                }
            }
            else
            {
                Media = (Media + Convert.ToDouble(txtRecuperacao.Text)) / 2;

                txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";    

                if(Media >= 5)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }
                else
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Red;
                }

                txtMediaFinal.Text = Media.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSituacao.Text = string.Empty;
            txtRecuperacao.Text = string.Empty;

            foreach(Control Componente in this.Controls)
            {
                if(Componente is TextBox)
                {
                    (Componente as TextBox).Clear();
                }

                else
                {
                    if(Componente is ComboBox)
                    {
                        (Componente as ComboBox).SelectedIndex = -1;
                    }

                    else
                        if(Componente is NumericUpDown)
                    {
                        (Componente as NumericUpDown).Value = 5;
                    }
                }
            }
        }
    }
}