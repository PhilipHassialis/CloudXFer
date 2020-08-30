using CloudXFerDBLayer.DBUtils.Interfaces;
using CloudXFerDBLayer.XFerProjects;

namespace CloudXFerDBLayer.DBUtils
{
    public class XFerProjectsFactory : IXFerProjectsFactory
    {
        XFerProject IXFerProjectsFactory.CreateEmptyProject(string projectName)
        {
            throw new System.NotImplementedException();
        }

        XFerProject IXFerProjectsFactory.GetProjectFromDB(string projectName)
        {
            throw new System.NotImplementedException();
        }
    }
}