using System;
using System.Collections.Generic;
using CloudXFerDBLayer.DBUtils;
using CloudXFerDBLayer.XFerProjects;
using Microsoft.AspNetCore.Mvc;

namespace CloudXFerWebApi.Controllers.XFerProjectsAPI
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class XFerAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<XFerProject> AllProjects()
        {
            XFerProjectsHelpers helpers = new XFerProjectsHelpers();
            return helpers.GetAllProjects();
        }

    }
}