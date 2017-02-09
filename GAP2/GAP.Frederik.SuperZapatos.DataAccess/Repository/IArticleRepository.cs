using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;
using GAP.Frederik.SuperZapatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Frederik.SuperZapatos.DataAccess.Repository
{
    public interface IArticleRepository
    {
        List<Article> GetArticles(ISystemResponse error);

        List<Article> GetArticlesByStoreId(int storeId, ISystemResponse error);

        bool CreateArticle(Store store, ISystemResponse error);
        bool UpdateArticle(Store store, ISystemResponse error);
        Article GetArticleById(int storeId, ISystemResponse error);
        bool DeleteArticle(int storeId, ISystemResponse error);
    }
}
