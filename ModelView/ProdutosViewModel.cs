using controledeestoque.Model;
using System;
using System.Windows.Forms;

namespace controledeestoque.ModelView
{
    public class ProdutosViewModel : BaseViewModel
    {
        public override void ButtonAction_Click(object sender, EventArgs e)
        {
            if (MeuButton.Text.Contains("CREATE"))
                DbEstoque.CreateProduto(new Produto { Nome = Txt.Text, Quantidade = (int)UpDown.Value, Categoria = Cb.SelectedItem.ToString() });
            else if (MeuButton.Text.Contains("DELETE"))
                DbEstoque.DeleteProduto(DbEstoque.GetProdutoById((int)DataEstoque.CurrentCell.Value));
            else if (MeuButton.Text.Contains("CHANGE"))
            {
                Produto produto = DbEstoque.GetProdutoById((int)DataEstoque.CurrentCell.Value);
                produto.Nome = Txt.Text;
                produto.Quantidade = (int)UpDown.Value;
                produto.Categoria = Cb.SelectedItem.ToString();
            }

            DbEstoque.SaveChanges();
            LoadDataGridView();
        }

        public override void DataGridAction_SelectionChanged(object sender, EventArgs e)
        {
            if (DataEstoque.CurrentCell.Value != null)
            {
                Produto produto = DbEstoque.GetProdutoById((int)DataEstoque.CurrentCell.Value);
                if (produto != null)
                {
                    Txt.Text = produto.Nome;
                    UpDown.Value = produto.Quantidade;
                    Cb.SelectedItem = produto.Categoria;
                }
            }
        }
    }
}
