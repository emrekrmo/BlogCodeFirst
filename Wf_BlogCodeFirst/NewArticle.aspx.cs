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
    public partial class NewArticle : System.Web.UI.Page
    {
        BlogContext db = new BlogContext();
        public List<Tag> AllTags { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            ddlCategory.DataValueField = "CategoryId";
            ddlCategory.DataTextField = "Name";
            ddlCategory.DataSource = db.Categories.Where(x => x.ParentCategoryId.HasValue).ToList();
            ddlCategory.DataBind();

                AllTags = db.Tags.ToList();
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Article a = new Article();
            a.CategoryId = Convert.ToInt32(ddlCategory.SelectedValue);
            a.Title = txtHeader.Text;
            a.Content = txtContent.Text;

            var tags = Request.Form["tags[]"];//Data is in 1,2,3 form
            var tagArray = tags.Split(',');//Now [1,2,3]
            
            a.Tags = db.Tags.Where(x => tagArray.Contains(x.TagId.ToString())).ToList();
;
            db.Articles.Add(a);
            db.SaveChanges();

            Response.Redirect("Default.aspx");
        }        
    }
}