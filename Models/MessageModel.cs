using MessageComponent;

namespace Assignment.Models
{
    public class MessageModel
    {

        public static MessageModel messageModel;
        private MessageModel()
        {}

        public static MessageModel getInstance()
        {
            if (messageModel == null)
            {
                messageModel = new MessageModel();
            }

            return messageModel;
        }

        public string messageManage { get; set; }
        
    }
}