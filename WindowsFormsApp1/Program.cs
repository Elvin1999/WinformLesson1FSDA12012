﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    #region MessageBox


    //static class Program
    //{

    //    static DialogResult GetDialogResult()
    //    {
    //        DialogResult result;

    //        string message = "Windows Display a text message";
    //        //result=MessageBox.Show(message);
    //        string caption = "C# Programming";
    //        //result = MessageBox.Show(message,caption,MessageBoxButtons.OKCancel);

    //        result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);

    //        return result;
    //    }

    //    /// <summary>
    //    /// The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        //Application.EnableVisualStyles();
    //        //Application.SetCompatibleTextRenderingDefault(false);
    //        //Application.Run(new Form1());

    //        var dialog = GetDialogResult();
    //        //if (dialog == DialogResult.OK)
    //        //{
    //        //    MessageBox.Show("You clicked to OK");
    //        //}
    //        //else if (dialog == DialogResult.Cancel)
    //        //{
    //        //    MessageBox.Show("You clicked to CANCEL");
    //        //}


    //        if (dialog == DialogResult.Abort)
    //        {
    //            MessageBox.Show("You clicked ABORT");
    //        }
    //        else if(dialog==DialogResult.Retry)
    //        {
    //            MessageBox.Show("You clicked RETRY");
    //        }
    //        else if (dialog == DialogResult.Ignore)
    //        {
    //            MessageBox.Show("You clicked IGNORE");
    //        }





    //    }
    //}


    #endregion


    #region Work With Forms

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion
    }

}