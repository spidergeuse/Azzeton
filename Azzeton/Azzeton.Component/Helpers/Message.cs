using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Azzeton.Components
{
    [Serializable()]
    public class Message
    {
        public Message() { this.SnapShots = new List<SnapShot>(); }
        public Message(string title, string message): this()
        {
            this.Title = title;
            this.Info = message;
            this.Code = "";
        }
        public Message(string title, string message, string code): this(title, message)
        {
            this.Code = code;
        }
        /// <summary>
        /// Title of current message
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Main content of current message
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// Code of current message
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// List of snapshot for current message
        /// </summary>
        public List<SnapShot> SnapShots { get; set; }
        /// <summary>
        /// String representation of message
        /// </summary>
        /// <returns>Returns a concatenation of title and code</returns>
        public override string ToString()
        {
            return this.Title + " " + this.Code;
        }
    }
    [Serializable()]
    public class SnapShot
    {
        public SnapShot(){}
        public SnapShot(string description):this()
        {
            this.Description = description;
        }
        public SnapShot(string description,byte[] imagedata):this(description)
        {
            this.ImageData = imagedata;
        }
        public byte[] ImageData{get;set;}
        public string Description {get;set;}
    }
}
