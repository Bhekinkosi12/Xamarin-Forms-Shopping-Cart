using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCarts.Model
{
    public class Message
    {
        private string _Text;
        public string Text { 
                            get{ return _Text; }
                            
                            set{ _Text = value; }
                           
                           }
        
        private string _User;
        public string User { get; set; }
    }
}
