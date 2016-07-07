namespace RestService
{
    public class RestServiceImpl : IRestServiceImpl
    {
        #region IRestServiceImpl Members

        public string XMLData(string id)
        {
            return "You requested product " + id;
        }

        public string JSONData(string id)
        {
            return "You requested product " + id;
        }

        public string Auth(RequestData rData)
        {
            // Call BLL here
            var data = rData.details.Split('|');
            return "You requested product " + 111;
        }

        #endregion
    }
}