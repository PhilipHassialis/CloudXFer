using CloudXFerDBLayer.DBUtils.Interfaces;
using CloudXFerDBLayer.XFerProjects;

namespace CloudXFerDBLayer.DBUtils
{
    public class XFerProjectsFactory : IXFerProjectsFactory
    {
        public XFerProject CreateEmptyProject(string projectName)
        {
            XFerProject newProject = new XFerProject() { ProjectConfig = new XFerProjectConfig() { ProjectName = projectName } };
            return newProject;
        }

        public XFerProject GetProjectFromDB(string projectName)
        {
            throw new System.NotImplementedException();
        }
    }
}