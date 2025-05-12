﻿using MySql.Data.MySqlClient;
using panorama;
using panorama.bancoDeDados;
using panorama.dominio;
using panorama.repositorio;
using System.Collections.Generic;


namespace costura
{
    public partial class pedido : Form
    {
        private PedidoCard cardSelecionado;

        public pedido()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void pedido_Load(object sender, EventArgs e)
        {
            CarregarPedidos(); // Chama o método assim que a tela é aberta
        }

        private void CarregarPedidos()
        {
            // Cria o repositório que acessa o banco
            PedidoRepositorio repositorio = new PedidoRepositorio();

            // Pega todos os pedidos que estão ativos no banco (não estão cancelados e nem concluidos)
            List<Pedido> listaPedidos = repositorio.ListarPedidosAtivos();

            // Limpa o painel onde os cards vão ser exibidos
            flow_pedidos.Controls.Clear();

            // Para cada pedido da lista, cria e exibe um card
            foreach (var pedido in listaPedidos)
            {
                // Cria um novo card visual
                var card = new PedidoCard();

                // Preenche os dados do card com as informações do pedido
                card.Id = pedido.Id;
                card.NomeCliente = pedido.NomeCliente;
                card.Telefone = pedido.Telefone;
                card.Preco = pedido.Preco;
                card.Pagamento = pedido.Pagamento;
                card.DataEntrega = pedido.DataEntrega;
                card.Situacao = pedido.Situacao;

                // Adiciona o card no painel de pedidos
                flow_pedidos.Controls.Add(card);

                // costroles de clique nos cards
                card.Click += (s, e) =>
                {
                    // Desabilita todos os cards e reseta o visual
                    foreach (PedidoCard c in flow_pedidos.Controls)
                    {
                        c.HabilitarEdicao(false);
                        c.BackColor = SystemColors.Control;
                    }

                    // Apenas destaca visualmente o card clicado
                    card.BackColor = Color.Yellow;

                    // Define como o card selecionado
                    cardSelecionado = card;
                };

            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private bool emEdicao = false; // controla o estado atual do botão cadastrar ( isso para alternar entre "cadastrar" e "salvar" quando quisermos editar um pedido 

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (!emEdicao)
            {
                if (cardSelecionado == null)
                {
                    MessageBox.Show("Clique em um pedido para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cardSelecionado.HabilitarEdicao(true);
                btn_atualizar.Text = "SALVAR";
                emEdicao = true;
            }
            else
            {
                // Pega os dados atualizados
                var pedidoAtualizado = new Pedido
                {
                    Id = cardSelecionado.Id,
                    NomeCliente = cardSelecionado.NomeCliente,
                    Telefone = cardSelecionado.Telefone,
                    Preco = cardSelecionado.Preco,
                    Pagamento = cardSelecionado.Pagamento,
                    DataEntrega = cardSelecionado.DataEntrega,
                    Situacao = cardSelecionado.Situacao
                };

                PedidoRepositorio repo = new PedidoRepositorio();
                repo.Atualizar(pedidoAtualizado);

                // Mostra mensagem de sucesso
                MessageBox.Show("Pedido atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se for "concluído" ou "cancelado", remover da tela
                string status = pedidoAtualizado.Situacao.ToLower();
                if (status == "concluído" || status == "cancelado")
                {
                    flow_pedidos.Controls.Remove(cardSelecionado);
                    // ➕ Em breve: adicionar ao histórico
                }

                cardSelecionado.HabilitarEdicao(false);
                cardSelecionado.BackColor = SystemColors.Control;
                btn_atualizar.Text = "Atualizar";
                emEdicao = false;
                cardSelecionado = null;
            }
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            historico historico = new historico();
            historico.Show();

            this.Hide();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historico Historico = new historico();
            Historico.Show();

            this.Hide();
        }
    }
}
