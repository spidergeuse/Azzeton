using System;
namespace Azzeton.Shared
{
    public class StatusEventArgs:EventArgs
    {
        public StatusEventArgs(int value,string text,object data)
        {
            this.Data = data;
            this.Text = text;
            this.Value = value;
        }
        public int Value { get; private set; }
        public string Text { get; private set; }
        public object Data { get; private set; }
    }
}
