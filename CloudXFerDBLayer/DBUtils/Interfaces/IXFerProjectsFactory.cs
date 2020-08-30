using CloudXFerDBLayer.XFerProjects;

namespace CloudXFerDBLayer.DBUtils.Interfaces
{
    public interface IXFerProjectsFactory
    {
        XFerProject CreateEmptyProject(string projectName);
        XFerProject GetProjectFromDB(string projectName);

    }
}