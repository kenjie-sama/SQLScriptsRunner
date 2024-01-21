using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerScriptExecute
{
	internal class Notification
	{
		private static string GetExceptionMessage(Exception ex, string introMessage = "") => introMessage + "\n\n" + "Error! " + ex.Message + "\n\n" + ex.StackTrace + "\n" + ex.Source;
		public static void Alert(Exception ex, string introMessage = "") => MessageBox.Show(GetExceptionMessage(ex, introMessage));
		public static void Log(Exception ex, string introMessage = "") => Debug.WriteLine(GetExceptionMessage(ex, introMessage));
	}
}
