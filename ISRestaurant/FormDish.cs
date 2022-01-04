using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    public partial class FormDish : Form
    {
        private int dishId;
        List<Ingredient> ingredients = new List<Ingredient>();

        public FormDish()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                cmBoxCategory.DataSource = db.Categories.ToList();
                cmBoxIngredient.DataSource = db.Ingredients.ToList();
            }
            Sourse();
        }

        public FormDish(Dish dish)
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                cmBoxCategory.DataSource = db.Categories.ToList();
                cmBoxIngredient.DataSource = db.Ingredients.ToList();
            }

            dishId = dish.id_dish;
            btnAddDish.Click -= btnAddDish_Click;
            btnAddDish.Click += btnUpdate_Click;
            btnAddDish.Text = "Обновить";

            checkSale.Checked = dish.on_sale;
            ingredients = dish.Ingredients.ToList();
            numericUpDown1.Value = dish.calories;
            txtBoxName.Text = dish.name;
            cmBoxCategory.SelectedValue = dish.id_category;

            Sourse();
        }

        private void Sourse()
        {
            BindingSource binding = new BindingSource();
            binding.SuspendBinding();
            binding.DataSource = ingredients;
            binding.ResumeBinding();

            dataGridView1.DataSource = binding;
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            if (cmBoxCategory.SelectedIndex == -1 || txtBoxName.TextLength == 0)
            {
                MessageBox.Show("Ошб.003 Заполните поля!!");
            }
            else
            {

                using (Context db = new Context())
                {
                    int[] ids = new int[ingredients.Count];
                    int id = 0;
                    foreach (Ingredient i in ingredients)
                    {
                        ids[id] = i.id_ingredient;
                        id++;
                    }
                    db.Dishes.Add(
                        new Dish
                        {
                            name = txtBoxName.Text,
                            calories = (int)numericUpDown1.Value,
                            id_category = (int)cmBoxCategory.SelectedValue,
                            on_sale = checkSale.Checked,
                            Ingredients = db.Ingredients.Where(i => ids.Contains(i.id_ingredient)).ToList()

                        });

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Ошб.005 Такая запись уже существует");
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Dish updateDish;

            using (Context db = new Context())
            {
                updateDish = db.Dishes.Where(d => d.id_dish == dishId).FirstOrDefault();

                updateDish.calories = (int)numericUpDown1.Value;
                updateDish.id_category = (int)cmBoxCategory.SelectedValue;
                updateDish.name = txtBoxName.Text;
                updateDish.Ingredients.Clear();
                updateDish.on_sale = checkSale.Checked;

                int[] ids = new int[ingredients.Count];
                int i = 0;
                foreach (Ingredient ing in ingredients)
                {
                    ids[i] = ing.id_ingredient;
                    i++;
                }
                updateDish.Ingredients = db.Ingredients.Where(ing => ids.Contains(ing.id_ingredient)).ToList();

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошб.1000 Непредвиденная ошибка");
                }
            }
        }

        private void btnInsertIngridient_Click(object sender, EventArgs e)
        {
            bool check = false;

            foreach (Ingredient i in ingredients)
            {
                if (i.id_ingredient == ((Ingredient)cmBoxIngredient.SelectedItem).id_ingredient)
                {
                    MessageBox.Show("Ошб.005 Такой ингридиент уже в составе");
                    check = true;
                }
            }

            if (check) return;

            ingredients.Add((Ingredient)cmBoxIngredient.SelectedItem);
            Sourse();
        }

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (Ingredient item in ingredients)
            {
                if (item.id_ingredient == (int)dataGridView1.SelectedRows[0].Cells[0].Value)
                {
                    ingredients.Remove(item);
                    Sourse();
                    return;
                }
            }

        }

    }
}
