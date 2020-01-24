﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.User_Controls
{
    public partial class MessageControl : UserControl
    {
        public MessageControl(string message)
        {
            InitializeComponent();
            lbl_message.Text = message;
        }
    }
}
