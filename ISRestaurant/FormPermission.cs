using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISRestaurant
{
    public partial class FormPermission : Form
    {
        enum PermissionVale
        {
            insert,
            remove,
            update,
        }
        int posId;
        bool init = true;
        public FormPermission(int posId)
        {
            InitializeComponent();
            this.posId = posId;

            List<Permission_table> permissions = new List<Permission_table>();    
            using (Context db = new Context())
            {
                lblPosName.Text = db.Positions.Where(p => p.id_position == posId).FirstOrDefault().name;
                permissions = db.Positions.Where(p => p.id_position == posId).FirstOrDefault().Permission_table.ToList();
            }

            foreach (Permission_table item in permissions)
            {
                string tableName;
                using (Context db = new Context())
                {
                    tableName = (db.tables.Where(t => t.id_table == item.id_table).First()).name;
                }

                switch (tableName)
                {
                    case "Category":
                        checkCategory.Checked = true;
                        categoryInsert.Checked = item.rule_insert;
                        categoryRemove.Checked = item.rule_delete;
                        categoryUpdate.Checked = item.rule_update;
                        break;
                    case "Dish":
                        checkDish.Checked = true;
                        dishInsert.Checked = item.rule_insert;
                        dishDelete.Checked = item.rule_delete;
                        dishUpdate.Checked = item.rule_update;
                        break;
                    case "Ingredient":
                        checkIngredient.Checked = true;
                        ingredientInsert.Checked = item.rule_insert;
                        ingredientDelete.Checked = item.rule_delete;
                        ingredientUpdate.Checked = item.rule_update;
                        break;
                    case "Position":
                        checkPosition.Checked = true;
                        positionInsert.Checked = item.rule_insert;
                        positionDelete.Checked = item.rule_delete;
                        positionUpdate.Checked = item.rule_update;
                        break;
                    case "Price":
                        checkPrice.Checked = true;
                        priceInsert.Checked = item.rule_insert;
                        priceDelete.Checked = item.rule_delete;
                        priceUpdate.Checked = item.rule_update;
                        break;
                    case "Worker":
                        checkWorker.Checked = true;
                        workerInsert.Checked = item.rule_insert;
                        workerDelete.Checked = item.rule_delete;
                        workerUpdate.Checked = item.rule_update;
                        break;
                    case "Order":
                        checkOrder.Checked = true;
                        orderInsert.Checked = item.rule_insert;
                        orderDelete.Checked = item.rule_delete;
                        orderUpdate.Checked = item.rule_update;
                        break;

                    default:
  
                        break;
                }           
            }
            init = false;
        }

        private void perView(object sender, string tableName, ref CheckBox update, ref CheckBox remove, ref CheckBox insert)
        {
            if (init)
            {
                return;
            }

            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                using (Context db = new Context())
                {
                    int idTable = (db.tables.Where(t => t.name == tableName).First()).id_table;
                    Permission_table permission = db.Permission_table.Where(p => p.id_position == posId && p.id_table == idTable).FirstOrDefault();
                    if (permission == null)
                    {
                        db.Permission_table.Add(new Permission_table
                        {
                            id_table = idTable,
                            id_position = posId,
                            rule_delete = false,
                            rule_update = false,
                            rule_insert = false
                        });
                    }

                    db.SaveChanges();
                }
            }
            else
            {
                using (Context db = new Context())
                {
                    int idTable = (db.tables.Where(t => t.name == tableName).First()).id_table;
                    Permission_table permission = db.Permission_table.Where(p => p.id_position == posId && p.id_table == idTable).FirstOrDefault();
                    if (permission != null)
                    {
                        db.Permission_table.Remove(permission);
                        remove.Checked = false;
                        update.Checked = false;
                        insert.Checked = false;

                    }

                    db.SaveChanges();
                }
            }

        }

        private void perChange(object sender, ref CheckBox view, string tableName,PermissionVale rule)
        {
            if (init)
            {
                return;
            }

            CheckBox check = (CheckBox)sender;
            if (view.Checked)
            {

                using (Context db = new Context())
                {
                    int idTable = (db.tables.Where(t => t.name == tableName).First()).id_table;
                    Permission_table permission = db.Permission_table.Where(p => p.id_position == posId && p.id_table == idTable).FirstOrDefault();
                    if (check.Checked)
                    {
                        switch (rule)
                        {
                            case PermissionVale.insert:
                                permission.rule_insert = true;
                                break;
                            case PermissionVale.remove:
                                permission.rule_delete = true;
                                break;
                            case PermissionVale.update:
                                permission.rule_update = true;
                                break;
                            default:
                                break;
                        }

                    }
                    else
                    {
                        switch (rule)
                        {
                            case PermissionVale.insert:
                                permission.rule_insert = false;
                                break;
                            case PermissionVale.remove:
                                permission.rule_delete = false;
                                break;
                            case PermissionVale.update:
                                permission.rule_update = false;
                                break;
                            default:
                                break;
                        };
                    }

                    db.SaveChanges();
                }
            }
            else
            {
                check.Checked = false;
            }
        }
        private void checkCategory_CheckedChanged(object sender, EventArgs e)
        {
            perView(sender, "Category", ref categoryUpdate, ref categoryRemove, ref categoryInsert);
        }

        private void categoryInsert_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkCategory, "Category",PermissionVale.insert);
        }

        private void categoryRemove_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkCategory, "Category", PermissionVale.remove);
        }

        private void categoryUpdate_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkCategory, "Category", PermissionVale.update);
        }

        private void checkDish_CheckedChanged(object sender, EventArgs e)
        {
            perView(sender, "Dish", ref dishUpdate, ref dishDelete, ref dishInsert);
        }

        private void dishInsert_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkDish, "Dish", PermissionVale.insert);
        }

        private void dishUpdate_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkDish, "Dish", PermissionVale.update);
        }

        private void dishDelete_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkDish, "Dish", PermissionVale.remove);
        }

        private void checkIngredient_CheckedChanged(object sender, EventArgs e)
        {
            perView(sender, "Ingredient", ref ingredientUpdate, ref ingredientDelete, ref ingredientInsert);
        }

        private void ingredientInsert_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkIngredient, "Ingredient", PermissionVale.insert);
        }

        private void ingredientUpdate_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkIngredient, "Ingredient", PermissionVale.update);
        }

        private void ingredientDelete_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkIngredient, "Ingredient", PermissionVale.remove);
        }

        private void checkPosition_CheckedChanged(object sender, EventArgs e)
        {
            perView(sender, "Position", ref positionUpdate, ref positionDelete, ref positionInsert);
        }

        private void positionInsert_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkPosition, "Position", PermissionVale.insert);
        }

        private void positionDelete_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkPosition, "Position", PermissionVale.remove);
        }

        private void positionUpdate_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkPosition, "Position", PermissionVale.update);
        }

        private void checkPrice_CheckedChanged(object sender, EventArgs e)
        {
            perView(sender, "Price", ref priceUpdate, ref priceDelete, ref priceInsert);
        }

        private void priceInsert_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkPrice, "Price", PermissionVale.insert);
        }

        private void priceUpdate_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkPrice, "Price", PermissionVale.update);
        }

        private void priceDelete_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkPrice, "Price", PermissionVale.remove);
        }

        private void checkWorker_CheckedChanged(object sender, EventArgs e)
        {
            perView(sender, "Worker", ref workerUpdate, ref workerDelete, ref workerInsert);
        }

        private void workerInsert_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkWorker, "Worker", PermissionVale.insert);
        }

        private void workerUpdate_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkWorker, "Worker", PermissionVale.update);
        }

        private void workerDelete_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkWorker, "Worker", PermissionVale.remove);
        }

        private void checkOrder_CheckedChanged(object sender, EventArgs e)
        {
            perView(sender, "Order", ref orderUpdate, ref orderDelete, ref orderInsert);
        }

        private void orderInsert_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkOrder, "Order", PermissionVale.insert);
        }

        private void orderUpdate_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkOrder, "Order", PermissionVale.update);
        }

        private void orderDelete_CheckedChanged(object sender, EventArgs e)
        {
            perChange(sender, ref checkOrder, "Order", PermissionVale.remove);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckQuerry_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Visible = false;
            perView(sender, "Querry", ref checkBox, ref checkBox, ref checkBox);
        }
    }
}
