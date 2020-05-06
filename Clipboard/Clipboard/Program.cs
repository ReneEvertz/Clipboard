using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			try
			{
				System.Windows.Forms.Clipboard.SetText(args[0] ?? "Leider nicht geklappt. Anleitung genau gelesen?");
			}
			catch (Exception)
			{
				System.Windows.Forms.Clipboard.SetText("Leider nicht geklappt. Anleitung genau gelesen?");
			}
		}
	}
}
