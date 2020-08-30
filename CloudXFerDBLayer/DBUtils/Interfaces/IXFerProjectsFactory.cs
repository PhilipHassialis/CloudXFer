using CloudXFerDBLayer.XFerProjects;

namespace CloudXFerDBLayer.DBUtils.Interfaces
{
    public interface IXFerProjectsFactory
    {
        public XFerProject CreateEmptyProject(string projectName);
        public XFerProject GetProjectFromDB(string projectName);

    }
}