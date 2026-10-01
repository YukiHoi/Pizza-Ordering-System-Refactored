using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDeliverySYS.Models;

namespace FoodDeliverySYS.Models
{
    public partial class frmAddFood : Form
    {
        private List<Pizza> pizzaList = new List<Pizza>();
        private int nextPizzaID = 1;
        private List<Topping> availableToppings;
        public frmAddFood()
        {
            InitializeComponent();
            InitializeFormData();
        }
        private void frmAddPizza_Load(object sender, EventArgs e)
        { 
            LoadPizzaSizes();
            LoadCrustTypes();
            LoadToppings();
        }
        private void InitializeFormData()
        {
            dvgPizzaList.AutoGenerateColumns = true;
            dvgToppingList.AutoGenerateColumns = true;
        }
        private void LoadPizzaNames()
        {
         
        }
        private void LoadPizzaSizes()
        {
            cmbPizzaSize.Items.AddRange(new string[] { "Small", "Medium", "Large", "Extra Large" });
        }
        private void LoadCrustTypes()
        {
            cmbCrustType.Items.AddRange(new string[] { "Thin", "Regular", "Cheese Stuffed" });
        }
        private void LoadToppings()
        {
            availableToppings = new List<Topping>

        {
            new Topping { ToppingID = 1, ToppingName = "Pepperoni slices - Pork", ToppingPrice = 2.00m },
            new Topping { ToppingID = 2, ToppingName = "Pepperoni slices - Beef", ToppingPrice = 2.50m },
            new Topping { ToppingID = 3, ToppingName = "Anchovy", ToppingPrice = 1.75m },
            new Topping { ToppingID = 4, ToppingName = "Mozzarella", ToppingPrice = 1.50m },
            new Topping { ToppingID = 5, ToppingName = "Sausage", ToppingPrice = 2.00m },
            new Topping { ToppingID = 6, ToppingName = "Mushrooms", ToppingPrice = 3.00m },
            new Topping { ToppingID = 7, ToppingName = "Grilled chicken", ToppingPrice = 2.00m },
            new Topping { ToppingID = 8, ToppingName = "Red onion", ToppingPrice = 1.75m },
            new Topping { ToppingID = 9, ToppingName = "Cheddar cheese", ToppingPrice = 1.50m },
            new Topping { ToppingID = 10, ToppingName = "Pine nuts", ToppingPrice = 3.50m },
            new Topping { ToppingID = 11, ToppingName = "Fresh basil leaves", ToppingPrice = 3.50m },
            new Topping { ToppingID = 12, ToppingName = "Green peppers", ToppingPrice = 3.50m },
            new Topping { ToppingID = 13, ToppingName = "Black olives", ToppingPrice = 3.50m },
            new Topping { ToppingID = 14, ToppingName = "Ham", ToppingPrice = 3.50m },
            new Topping { ToppingID = 15, ToppingName = "Pineapple chunks", ToppingPrice = 3.50m },
            new Topping { ToppingID = 16, ToppingName = "Bacon", ToppingPrice = 3.50m },
            new Topping { ToppingID = 17, ToppingName = "Ground beef", ToppingPrice = 3.50m },
            new Topping { ToppingID = 18, ToppingName = "Prawns", ToppingPrice = 3.50m }
        };
            clbToppings.DisplayMember = nameof(Topping.ToppingName);
            clbToppings.Items.Clear();

            foreach (var topping in availableToppings)
            {
                clbToppings.Items.Add(topping, false);
            }
        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            if (!ValidatePizzaSelection())
            {
                MessageBox.Show("Please select a pizza name, size, and crust type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCrustType.SelectedItem == null || cmbPizzaSize.SelectedItem == null)
            {
                MessageBox.Show("Please select a crust type and pizza size.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clbToppings.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one topping.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedToppings = clbToppings.CheckedItems.Cast<object>()
                .Select(item => item as Topping)
                .Where(topping => topping != null)
                .ToList();

            decimal basePrice = 9.99m;
            decimal crustPrice;
            switch (cmbCrustType.SelectedItem.ToString())
            {
                case "Thin":
                    crustPrice = 1.00m;
                    break;
                case "Regular":
                    crustPrice = 2.00m;
                    break;
                case "Cheese Stuffed":
                    crustPrice = 3.00m;
                    break;
                default:
                    crustPrice = 0.00m;
                    break;
            }
          
            decimal sizePrice;
            switch (cmbPizzaSize.SelectedItem.ToString())
            {
                case "Small":
                    sizePrice = 0.00m;
                    break;
                case "Medium":
                    sizePrice = 2.00m;
                    break;
                case "Large":
                    sizePrice = 4.00m;
                    break;
                case "Extra Large":
                    sizePrice = 6.00m;
                    break;
                default:
                    sizePrice = 0.00m;
                    break;
            }

            decimal toppingsPrice = selectedToppings.Sum(t => t.ToppingPrice);
            decimal totalPrice = basePrice + crustPrice + sizePrice + toppingsPrice;

            var pizza = new Pizza
            {
                PizzaID = nextPizzaID++,
                PizzaName = txtPizzaName.ToString(),
                PizzaSize = cmbPizzaSize.SelectedItem.ToString(),
                CrustType = cmbCrustType.SelectedItem.ToString(),
                Toppings = selectedToppings,
                TotalPrice = CalculatePizzaPrice(
                    cmbPizzaSize.SelectedItem.ToString(),
                    cmbCrustType.SelectedItem.ToString(),
                    selectedToppings
                )
            };
            pizzaList.Add(pizza);

            RefreshPizzaGrid();
            RefreshToppingsGrid(pizza.PizzaID);

            MessageBox.Show("Pizza added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }
        private bool ValidatePizzaSelection()
        {
            return txtPizzaName != null &&
                   cmbPizzaSize.SelectedItem != null &&
                   cmbCrustType.SelectedItem != null &&
                   clbToppings.CheckedItems.Count > 0;
        }

        private decimal CalculatePizzaPrice(string size, string crust, List<Topping> selectedToppings)
        {
            decimal basePrice = 9.99m;

            switch (size)
            {
                case "Small": basePrice += 0; break;
                case "Medium": basePrice += 2.00m; break;
                case "Large": basePrice += 4.00m; break;
                case "Extra Large": basePrice += 6.00m; break;
            }

            switch (crust)
            {
                case "Thin": basePrice += 1.00m; break;
                case "Regular": basePrice += 2.00m; break;
                case "Cheese Stuffed": basePrice += 3.00m; break;
            }

            basePrice += selectedToppings.Sum(t => t.ToppingPrice);
            return basePrice;
        }
        private void RefreshPizzaGrid()
        {
            dvgPizzaList.DataSource = null;
            dvgPizzaList.DataSource = pizzaList.Select(p => new
            {
                PizzaID = p.PizzaID,
                PizzaName = p.PizzaName,
                CrustType = p.CrustType,
                PizzaSize = p.PizzaSize,
                TotalPrice = $"€{p.TotalPrice:N2}"
            }).ToList();
        }
        private void RefreshToppingsGrid(int pizzaID)
        {
            var selectedPizza = pizzaList.FirstOrDefault(p => p.PizzaID == pizzaID);

            if (selectedPizza != null)
            {
                dvgToppingList.DataSource = null;
                dvgToppingList.DataSource = selectedPizza.Toppings.Select(t => new
                {
                    ToppingID = t.ToppingID,
                    ToppingName = t.ToppingName,
                    ToppingPrice = $"€{t.ToppingPrice:N2}"
                }).ToList();
            }
        }
        private void dvgPizzaList_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgPizzaList.SelectedRows.Count > 0)
            {
                int selectedPizzaID = Convert.ToInt32(dvgPizzaList.SelectedRows[0].Cells["PizzaID"].Value);
                RefreshToppingsGrid(selectedPizzaID);
            }
        }
        private void ClearForm()
        {
            txtPizzaName.Clear(); 
            cmbCrustType.SelectedIndex = -1; 
            cmbPizzaSize.SelectedIndex = -1; 

            for (int i = 0; i < clbToppings.Items.Count; i++)
            {
                clbToppings.SetItemChecked(i, false); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPizzaName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dvgToppingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddPizza_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPizzaName.Text))
            {
                MessageBox.Show("Please enter a pizza name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             if (cmbCrustType.SelectedItem == null || cmbPizzaSize.SelectedItem == null)
    {
        MessageBox.Show("Please select a crust type and pizza size.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }
            var selectedToppings = clbToppings.CheckedItems.Cast<Topping>().ToList();

            decimal basePrice = 9.99m;
            decimal crustPrice;
            switch (cmbCrustType.SelectedItem.ToString())
            {
                case "Thin":
                    crustPrice = 1.00m;
                    break;
                case "Regular":
                    crustPrice = 2.00m;
                    break;
                case "Cheese Stuffed":
                    crustPrice = 3.00m;
                    break;
                default:
                    crustPrice = 0.00m;
                    break;
            }
            decimal sizePrice;
            switch (cmbPizzaSize.SelectedItem.ToString())
            {
                case "Small":
                    sizePrice = 0.00m;
                    break;
                case "Medium":
                    sizePrice = 2.00m;
                    break;
                case "Large":
                    sizePrice = 4.00m;
                    break;
                case "Extra Large":
                    sizePrice = 6.00m;
                    break;
                default:
                    sizePrice = 0.00m;
                    break;
            }
            decimal toppingsPrice = selectedToppings.Sum(t => t.ToppingPrice);
            decimal totalPrice = basePrice + crustPrice + sizePrice + toppingsPrice;

         
            var pizza = new Pizza
            {
                PizzaID = pizzaList.Count + 1, 
                PizzaName = txtPizzaName.ToString(),
                CrustType = cmbCrustType.SelectedItem.ToString(),
                PizzaSize = cmbPizzaSize.SelectedItem.ToString(),
                Toppings = selectedToppings,
                TotalPrice = totalPrice
            };
            pizzaList.Add(pizza);
            RefreshPizzaGrid();
            RefreshToppingsGrid(pizza.PizzaID);

            MessageBox.Show("Pizza added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            ClearForm();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clbToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
