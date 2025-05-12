﻿namespace panorama
{
    public partial class PedidoCard : UserControl
    {
        public int Id { get; set; }

        public PedidoCard()
        {
            InitializeComponent();
            HabilitarEdicao(false);
            ConfigurarClique();
            this.BackColor = GerarCorForteAleatoria();
        }

        public string NomeCliente
        {
            get { return txb_nome.Text; }
            set { txb_nome.Text = value; }
        }

        public string Telefone
        {
            get { return txb_telefone.Text; }
            set { txb_telefone.Text = value; }
        }

        public decimal Preco
        {
            get
            {
                decimal preco;
                decimal.TryParse(txb_preco.Text, out preco);
                return preco;
            }
            set { txb_preco.Text = value.ToString("F2"); }
        }

        public string Pagamento
        {
            get { return txb_pagamento.Text; }
            set { txb_pagamento.Text = value; }
        }

        public DateTime DataEntrega
        {
            get
            {
                DateTime data;
                DateTime.TryParse(txb_entrega.Text, out data);
                return data;
            }
            set
            {
                txb_entrega.Text = value.ToString("dd/MM/yyyy HH:mm");
            }
        }

        public string Situacao
        {
            get { return txb_situacao.Text; }
            set { txb_situacao.Text = value; }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void HabilitarEdicao(bool habilitar)
        {
            txb_nome.Enabled = habilitar;
            txb_telefone.Enabled = habilitar;
            txb_preco.Enabled = habilitar;
            txb_pagamento.Enabled = habilitar;
            txb_entrega.Enabled = habilitar;
            txb_situacao.Enabled = habilitar;
        }

        private void ConfigurarClique()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += (s, e) => this.OnClick(e); // Faz qualquer clique interno acionar o clique do card
            }
        }

        private Color GerarCorForteAleatoria()
        {
            Color[] coresFortes = new Color[]
            {
        Color.DarkBlue,
        Color.DarkRed,
        Color.DarkGreen,
        Color.MidnightBlue,
        Color.DarkSlateGray,
        Color.Indigo,
        Color.Firebrick,
        Color.Maroon,
        Color.DarkOliveGreen
            };

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return coresFortes[rnd.Next(coresFortes.Length)];
        }

        private void PedidoCard_Load(object sender, EventArgs e)
        {
            // Deixa todos os campos em maiúsculo
            txb_nome.CharacterCasing = CharacterCasing.Upper;
            txb_pagamento.CharacterCasing = CharacterCasing.Upper;
            txb_situacao.CharacterCasing = CharacterCasing.Upper;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
