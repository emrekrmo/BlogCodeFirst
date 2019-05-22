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
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        BlogContext db = new BlogContext();
        public List<Category> TopCategories { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            TopCategories = db.Categories.Where(x => !x.ParentCategoryId.HasValue).ToList();
        }
    }
}