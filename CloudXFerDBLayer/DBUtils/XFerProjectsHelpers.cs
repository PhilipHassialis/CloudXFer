using System.Collections.Generic;
using CloudXFerDBLayer.DBUtils.Interfaces;
using CloudXFerDBLayer.XFerProjects;

namespace CloudXFerDBLayer.DBUtils
{
    public class XFerProjectsHelpers : IXFerProjectHelpers
    {
        public IEnumerable<XFerProject> GetAllProjects()
        {
            List<XFerProject> allProjects = new List<XFerProject>()
            {
                new XFerProject() { ProjectConfig = new XFerProjectConfig() { ProjectName = "TestProj1" } },
                new XFerProject() { ProjectConfig = new XFerProjectConfig() { ProjectName = "TestProj2" } }
            };

            return allProjects;
        }
    }
}