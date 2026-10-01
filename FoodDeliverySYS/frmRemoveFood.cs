using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySYS
{
    public partial class frmRemoveFood : Form
    {
        private List<string> availablePizzas;

        public frmRemoveFood()
        {
            InitializeComponent();
            InitializePizzaList();
            PopulatePizzaList();
        }
     
        
        private void InitializePizzaList()
        {
            availablePizzas = new List<string>
            {
                "Pepperoni",
                "Anchovy",
                "Mozzarella",
                "Pesto",
                "New York Style Pizza",
                "BBQ Chicken Pizza"
            };
        }
        private void PopulatePizzaList()
        {
            lblSelectedPizza.Items.Clear();

            if (availablePizzas.Count == 0)
            {
                MessageBox.Show("No pizzas available to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSelectedPizza.Enabled = false;
                btnRemovePizza.Enabled = false;
            }
            else
            {
                lblSelectedPizza.Enabled = true;
                btnRemovePizza.Enabled = true;

                foreach (var pizza in availablePizzas)
                {
                    lblSelectedPizza.Items.Add(pizza);
                }
            }
        }

        private void btnRemovePizza_Click(object sender, EventArgs e)
        {

            string selectedPizza = lblSelectedPizza.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedPizza))
            {
                MessageBox.Show("Please select a pizza to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmResult = MessageBox.Show(
                $"Are you sure you want to remove '{selectedPizza}'?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmResult == DialogResult.Yes)
            {
                
                availablePizzas.Remove(selectedPizza);
                PopulatePizzaList();

                MessageBox.Show($"'{selectedPizza}' has been removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstPizzaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPizza = lblSelectedPizza.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedPizza))
            {
                lblSelectedPizza.Text = $"Selected: {selectedPizza}";
            }
        }
    }
    }

