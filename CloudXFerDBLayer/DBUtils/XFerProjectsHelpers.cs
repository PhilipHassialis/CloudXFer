using System.Collections.Generic;
using CloudXFerDBLayer.DBUtils.Interfaces;
using CloudXFerDBLayer.Utils;
using CloudXFerDBLayer.XFerProjects;
using Microsoft.Data.Sqlite;
using Dapper;
using CloudXFerDBLayer.DBUtils.ConfigDbMaintenance;
using System;

namespace CloudXFerDBLayer.DBUtils
{
    public class XFerProjectsHelpers : IXFerProjectHelpers
    {
        public IEnumerable<XFerProject> GetAllProjects()
        {
            List<XFerProject> allProjects = new List<XFerProject>();
            // {
            //     new XFerProject() { ProjectConfig = new XFerProjectConfig() { ProjectName = "TestProj1" } },
            //     new XFerProject() { ProjectConfig = new XFerProjectConfig() { ProjectName = "TestProj2" } }
            // };

            using (var conn = new SqliteConnection(Statics.ConfigDBConnString))
            {
                try
                {
                    conn.Open();
                    if (DBMaintenance.InstantiatedDB(conn))
                    {

                    }

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }

            }

            return allProjects;
        }

        public void CreateXFerProject(string projectName)
        {
            XFerProject newXFerProject = new XFerProject();
            newXFerProject.ProjectConfig = new XFerProjectConfig() { ProjectName = projectName, ProjectCommands = new List<XFerProjectCommand>() };

            using (var conn = new SqliteConnection(Statics.ConfigDBConnString))
            {
                try
                {
                    conn.Open();
                    if (!DBMaintenance.InstantiatedDB(conn)) DBMaintenance.InstantiateDB(conn);
                    conn.Execute(@"INSERT INTO CXFProjects (ProjectName,ProjectCreationTime) VALUES (@ProjectName, @ProjectCreationTime)",
                    new { ProjectName = projectName, ProjectCreationTime = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString() });
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }

            }



        }

    }
}