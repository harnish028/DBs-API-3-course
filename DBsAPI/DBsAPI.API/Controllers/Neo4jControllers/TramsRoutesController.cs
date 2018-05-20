﻿using DBsAPI.DBsQueries;
using System;
using System.Web.Http;

namespace DBsAPI.Controllers.Neo4jControllers
{
    [RoutePrefix("api/tramsroutes")]
    public class TramsRoutesController : ApiController
    {
        private readonly Neo4jQueries _neo4jQueries;

        public TramsRoutesController()
        {
            _neo4jQueries = new Neo4jQueries();
        }

        [Route("createroute")]
        [HttpPost]
        public int CreateRoute()
        {
            throw new NotImplementedException();
        }
    }
}