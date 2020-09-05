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
        XFerProjectsHelpers helpers;

        public XFerAPIController()
        {
            helpers = new XFerProjectsHelpers();
        }

        [HttpGet]
        public IEnumerable<XFerProject> AllProjects()
        {

            return helpers.GetAllProjects();
        }

        [HttpGet]
        public void InsertRandoProject()
        {
            helpers.CreateXFerProject($"PROJ_{DateTime.Now.ToShortDateString()}");
        }

    }
}