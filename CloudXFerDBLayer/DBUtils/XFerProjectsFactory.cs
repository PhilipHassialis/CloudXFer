using CloudXFerDBLayer.DBUtils.Interfaces;
using CloudXFerDBLayer.XFerProjects;
using Microsoft.Data.Sqlite;

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
            XFerProject loadedProject = null;
            using (var dbconn = new SqliteConnection("Data Source=CloudXFerConfig.db"))
            {
                dbconn.Open();
                var command = dbconn.CreateCommand();
                command.CommandText = @"SELECT projectname from xferprojects WHERE projectname = $projname";
                command.Parameters.AddWithValue("$projname", projectName);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        loadedProject = new XFerProject() { ProjectConfig = new XFerProjectConfig() { ProjectName = reader["projectname"].ToString() } };
                    }
                }

            }
            return loadedProject;
        }
    }
}