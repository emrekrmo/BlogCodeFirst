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
    public partial class Default : System.Web.UI.Page
    {
        BlogContext db = new BlogContext();
        public List<Article> Articles { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Articles = db.Articles.OrderByDescending(x => x.ArticleId).ToList();
        }
    }
}