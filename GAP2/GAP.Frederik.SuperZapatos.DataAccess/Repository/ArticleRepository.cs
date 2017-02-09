using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAP.Frederik.SuperZapatos.DataAccess.Context;
using GAP.Frederik.SuperZapatos.Model;
using System.Data.Entity;
using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;

namespace GAP.Frederik.SuperZapatos.DataAccess.Repository
{
    public class ArticleRepository : RepositoryBase<SuperZapatosContext>, IArticleRepository
    {
        public bool CreateArticle(Store store, ISystemResponse error)
        {
            throw new NotImplementedException();
        }

        public bool DeleteArticle(int storeId, ISystemResponse error)
        {
            throw new NotImplementedException();
        }

        public Article GetArticleById(int storeId, ISystemResponse error)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticles(ISystemResponse error)
        {
            List<Article> articles = new List<Article>();

            try
            {
                using (DataContext)
                {
                    articles = DataContext.Articles.ToList();
                }
            }
            catch (Exception ex)
            {
                error.Error = true;
                error.Message = "Ocurrio un error al obtener los articulos";
                error.Exception = ex;
            }

            return articles;
        }        

        public List<Article> GetArticlesByStoreId(int storeId, ISystemResponse error)
        {
            List<Article> articles = new List<Article>();

            try
            {
                using (DataContext)
                {
                    articles = DataContext.Articles
                                .Where(a => a.store_id == storeId)
                                .ToList();
                }
            }
            catch (Exception ex)
            {
                error.Error = true;
                error.Message = "Ocurrio un error al obtener los articulos de la tienda solicitada";
                error.Exception = ex;
            }

            return articles;
        }

        public bool UpdateArticle(Store store, ISystemResponse error)
        {
            throw new NotImplementedException();
        }
    }
}
