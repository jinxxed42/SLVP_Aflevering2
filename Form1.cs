namespace SLVP_Aflevering2
{
    public partial class Form1 : Form
    {

        private List<Food> foodList = new List<Food>();
        private int _dgvInputSelectionIndex = -1; // Field for remembering the last line the user clicked in the DataGridView. -1 equals header or no valid line.

        public Form1()
        {
            InitializeComponent();

            Food f1 = new Food("Cognac", "Drikkevarer", 0.99, -0.02, 4.8, 0.37, 2.07, 0.01);
            foodList.Add(f1);
            Food f2 = new Food("Pulled pork", "Kød/fjerkræ", 2.3, 0.45, 0.18, 0.64, 0.1, 0);
            foodList.Add(f2);
            Food f3 = new Food("Hvidkål, rå", "Grøntsager", 0.1, 0.02, 0, 0.06, 0.05, 0.01);
            foodList.Add(f3);

            dgvUpdate();

            // We make sure to check if the DataBinding is completed before removing the Selection. Otherwise the DataGridView might load
            // with the first cell selected by default.
            dgvInput.DataBindingComplete += DgvInput_DataBindingComplete;
        }

        private void DgvInput_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInput.ClearSelection();
        }


        private void dgvUpdate()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = foodList;
            dgvInput.DataSource = bs;
            for (int i = 0; i < dgvInput.ColumnCount; i++)
            {
                dgvInput.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string category = tbCategory.Text;
            string errorMessage = "";
            bool badInput = false;
            if (!double.TryParse(tbAgriculture.Text, out double agricultureCO2))
            {
                errorMessage += "The input for agriculture CO2 is not a valid value.\n";
                badInput = true;
            }
            if (!double.TryParse(tbILUC.Text, out double ilucCO2))
            {
                errorMessage += "The input for ILUC CO2 is not a valid value.\n";
                badInput = true;
            }
            if (!double.TryParse(tbProduction.Text, out double productionCO2))
            {
                errorMessage += "The input for production CO2 is not a valid value.\n";
                badInput = true;
            }
            if (!double.TryParse(tbPackaging.Text, out double packagingCO2))
            {
                errorMessage += "The input for packaging CO2 is not a valid value.\n";
                badInput = true;
            }
            if (!double.TryParse(tbTransport.Text, out double transportCO2))
            {
                errorMessage += "The input for transport CO2 is not a valid value.\n";
                badInput = true;
            }
            if (!double.TryParse(tbStore.Text, out double storeCO2))
            {
                errorMessage += "The input for store CO2 is not a valid value.\n";
                badInput = true;
            }
            if (badInput)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            Food f = new Food(tbName.Text, tbCategory.Text, agricultureCO2, ilucCO2, productionCO2, packagingCO2, transportCO2, storeCO2);
            //double result = f.CalcCO2();
            tbResult.Text = f.CO2.ToString();
            foodList.Add(f);
            dgvUpdate();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            if (_dgvInputSelectionIndex == -1)
            {
                foodList.Clear();
            }
            else
            {
                foodList.RemoveAt(_dgvInputSelectionIndex);
                btnClear.Text = "Clear input";
                _dgvInputSelectionIndex = -1;
            }

            dgvUpdate();
        }

        // Testing for clicks in any cell in the DataGridView and updating the clear button and selection index accordingly.
        private void dgvInput_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnClear.Text = "Remove line";
                _dgvInputSelectionIndex = e.RowIndex;
            }
            else
            {
                btnClear.Text = "Clear input";
                _dgvInputSelectionIndex = -1;
                dgvInput.ClearSelection();
            }
        }

        // Testing for clicks on blank space in the DataGridView and updating the clear button and selection index accordingly.
        private void dgvInput_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo ht = dgvInput.HitTest(e.X, e.Y);
            if (ht.Type == DataGridViewHitTestType.None)
            {
                btnClear.Text = "Clear input";
                _dgvInputSelectionIndex = -1;
                dgvInput.ClearSelection();

            }
        }
    }
}