using System.Collections.Generic;
using CloudXFerDBLayer.XFerProjects;

namespace CloudXFerDBLayer.DBUtils.Interfaces
{
    public interface IXFerProjectHelpers
    {
        IEnumerable<XFerProject> GetAllProjects();
        void CreateXFerProject(string projectName);
    }
}