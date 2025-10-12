/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 * 
 * __________________________________________________
 * 
 * This is our implementation of the Booking System of Phumla Kamnandi
 */

using System;
using System.Windows.Forms;
using Phumla_Kamnandi_GRP_12.Presentation;

public class Program
{
    /// <summary>
    ///  Phumla Kamnandi Booking system 
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Login());
    }
}

