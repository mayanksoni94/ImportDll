using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ImportDll.Droid.Renderer;
using ImportDll.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(MyMessage))]
namespace ImportDll.Droid.Renderer
{
    public class MyMessage : IMessage
    {
        String msg = String.Empty;
        public MyMessage() { }

        public String helloMessage()
        {
            Message.MyMessage message = new Message.MyMessage();
             msg = message.HelloMessage();
            return msg;
        }

        public String goodbyeMessage()
        {
            Message.MyMessage message = new Message.MyMessage();
            msg = message.ByeMessage();
            return msg;
        }

    }
}