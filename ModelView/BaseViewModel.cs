using controledeestoque.Data;
using controledeestoque.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controledeestoque.ModelView
{
    public class BaseViewModel
    {
        private static readonly EstoqueContext context = new EstoqueContext();
        public readonly SqlCommands DbEstoque = new SqlCommands(context);
        public TextBox Txt { get; set; }
        public NumericUpDown UpDown { get; set; }
        public ComboBox Cb { get; set; }
        private DataGridView dataGrid;
        public DataGridView DataEstoque
        {
            get
            {
                return dataGrid;
            }
            set
            {
                dataGrid = value;
                dataGrid.Click += new EventHandler(this.DataGridAction_SelectionChanged);
            }
        }

        public virtual void DataGridAction_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        Button btn;
        public Button MeuButton
        {
            get
            {
                return btn;
            }
            set
            {
                btn = value;
                btn.Click += new EventHandler(this.ButtonAction_Click);
            }
        }

        public virtual void ButtonAction_Click(object sender, EventArgs e)
        {
        }

        public void populateCategoria()
        {
            Cb.Items.AddRange(new string[] { "Refrigerante","Salgado","Bolacha","Cerveja","Tempero","Comida instântanea","Frios"});
        }

        public void LoadDataGridView()
        {
            DataEstoque.DataSource = new BindingSource(DbEstoque.GetAllProdutos().ToList(), null);
        }
    }
}
