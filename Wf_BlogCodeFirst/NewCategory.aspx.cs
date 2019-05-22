using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wf_BlogCodeFirst
{
    public partial class NewCategory : System.Web.UI.Page
    {
        BlogContext db = new BlogContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            List<Category> list = db.Categories.ToList();

            Category c = new Category();
            c.CategoryId = 0;
            c.Name = "None";

            list.Insert(0, c); //None value now added as first element

            ddlCat.DataTextField = "Name";
            ddlCat.DataValueField = "CategoryId";
            ddlCat.DataSource = list;
            ddlCat.DataBind();
            }
        }

        protected void btnCat_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            if (ddlCat.SelectedValue != "0")
                c.ParentCategoryId = Convert.ToInt32(ddlCat.SelectedValue);

            c.Name = txtCat.Text;

            db.Categories.Add(c);
            db.SaveChanges();

            Response.Redirect("NewCategory.aspx?success=1");
        }
    }
}