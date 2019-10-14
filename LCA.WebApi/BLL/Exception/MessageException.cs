using System.Runtime.Serialization;

namespace LCA.WebApi.BLL.Exception
{
    /// <summary>
    /// Message
    /// </summary>
    [DataContract]
    public class MessageException
    {
        /// <summary>
        /// Text of the message
        /// </summary>
        [DataMember]
        public string Text { get; set; }

        /// <summary>
        /// ID unique
        /// </summary>
        [DataMember]
        public string ID { get; set; }
    }
}