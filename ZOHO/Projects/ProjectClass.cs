namespace Zoho_Migration.ZOHO.Projects
{
    public class ProjectClass
    {
        public dynamic id;
        public dynamic projectName;
        public dynamic projectDescription;
        public dynamic startDate;
        public dynamic endDate;
        public dynamic status;
        public dynamic owner;
        public dynamic projectKey;

        public ProjectClass(dynamic prjectKey,dynamic id, dynamic projectName, dynamic projectDescription, dynamic startDate, dynamic endDate, dynamic status, dynamic owner)
        {
            this.id = id;
            this.projectKey = prjectKey;
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.owner = owner;
        }
    }
}
