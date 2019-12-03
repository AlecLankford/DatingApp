namespace DatingApp.API.Helpers
{
    public class MessageParams
    {
        //Sets max page size to 50
        private const int MaxPageSize = 50;

        //Sets default page number to 1
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public int UserId { get; set; }
        public string MessageContainer { get; set; } = "Unread";
    }
}