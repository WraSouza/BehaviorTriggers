using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BehaviorTriggers.lib
{
    public class EmailValidoTrigger : TriggerAction<Entry>
    {
        //É necessário implementar essa método
        protected override void Invoke(Entry sender)
        {
            if(sender.Text.IndexOf('@') >= 0)
            {
                sender.TextColor = Color.Green;
            }
            else
            {
                sender.TextColor = Color.Red;
            }
           
        }
    }
}
