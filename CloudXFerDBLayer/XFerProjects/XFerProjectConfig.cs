using System.Collections.Generic;

namespace CloudXFerDBLayer.XFerProjects
{
    public class XFerProjectConfig
    {
        public string ProjectName { get; set; }
        public List<XFerProjectCommand> ProjectCommands { get; set; }
    }
}