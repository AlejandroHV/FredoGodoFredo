using GAP.Frederik.SuperZapatos.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using GAP.Frederik.SuperZapatos.Model;
using GAP.Frederik.SuperZapatos.Model.Factory;
using GAP.Frederik.SuperZapatos.WebAPI.Filters;
using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;

namespace GAP.Frederik.SuperZapatos.WebAPI.Controllers
{
    [ZapatosAPIAuthorize]
    [RoutePrefix("services/articles")]
    public class ArticlesController : ApiController
    {
        IArticleRepository _repository;
        ModelFactory _modelFactory;

        public ArticlesController(IArticleRepository repository)
        {
            _repository = repository;
            _modelFactory = new ModelFactory();
        }

        /// <summary>
        /// Return a list of all articles
        /// </summary>
        /// <returns></returns>
        [Route("")]
        public IHttpActionResult Get()
        {
            ISystemResponse error = new SystemResponse();
            var articles = _repository.GetArticles(error);
            var response = _modelFactory.Create(articles);

            return Ok(response);
        }


        /// <summary>
        /// Get all articles related to the store 
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [Route("stores/{storeId}")]
        public IHttpActionResult Get(int storeId)
        {
            ISystemResponse error = new SystemResponse();
            var articles = _repository.GetArticlesByStoreId(storeId, error);
            var response = _modelFactory.Create(articles);

            return Ok(response);

        }
    }
}