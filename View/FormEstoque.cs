using controledeestoque.Model;
using controledeestoque.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controledeestoque.View
{
    public partial class FormEstoque : Form
    {
        ProdutosViewModel pvw = null;
        ProdutosViewModel createBtn = null;
        ProdutosViewModel deleteBtn = null;
        ProdutosViewModel changeBtn = null;
        public FormEstoque()
        {
            InitializeComponent();
            pvw = new ProdutosViewModel { DataEstoque = dataGridViewProdutos, Txt = txtNome, Cb = cbCategoria, UpDown = updownQuantidade };
            createBtn = new ProdutosViewModel { DataEstoque = dataGridViewProdutos, Txt = txtNome, Cb = cbCategoria, UpDown = updownQuantidade, MeuButton = btnCreate };
            deleteBtn = new ProdutosViewModel { DataEstoque = dataGridViewProdutos, Txt = txtNome, Cb = cbCategoria, UpDown = updownQuantidade, MeuButton = btnDelete };
            changeBtn = new ProdutosViewModel { DataEstoque = dataGridViewProdutos, Txt = txtNome, Cb = cbCategoria, UpDown = updownQuantidade, MeuButton = btnChange };
            pvw.populateCategoria();
            pvw.LoadDataGridView();
        }
    }
}
