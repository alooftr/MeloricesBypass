using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

//                     LEAKED AND DEOBFUSCATED BY MRREVERSE ON GITHUB
//                     I DO NOT THINK IT WORKS

// Token: 0x0200000D RID: 13
internal class Class5
{
	// Token: 0x0600005D RID: 93 RVA: 0x00005FC0 File Offset: 0x000041C0
	[STAThread]
	private static void Main(string[] args)
	{
		foreach (Process process in Process.GetProcessesByName("csgo"))
		{
			process.Kill();
			Thread.Sleep(500);
			foreach (Process process2 in Process.GetProcessesByName("steam"))
			{
				process2.Kill();
			}
		}
		foreach (Process process3 in Process.GetProcessesByName("steam"))
		{
			process3.Kill();
		}
		if (File.Exists("D:\\steam\\steam.exe"))
		{
			string text = "D:\\steam\\steam.exe";
			string arguments = "/C netsh advfirewall firewall add rule name=SteamB dir=out action=block program=" + text + " enable=yes";
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					WindowStyle = ProcessWindowStyle.Hidden,
					Arguments = arguments
				}
			}.Start();
			string arguments2 = "/C netsh advfirewall firewall add rule name=SteamB dir=in action=block program=" + text + " enable=yes";
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					WindowStyle = ProcessWindowStyle.Hidden,
					Arguments = arguments2
				}
			}.Start();
			string arguments3 = "steam://rungameid/730";
			Process.Start(text, arguments3);
		}
		else if (!File.Exists("C:\\Program Files\\steam\\steam.exe"))
		{
			if (File.Exists("C:\\Program Files (x86)\\steam\\steam.exe"))
			{
				string text2 = "C:\\Program Files (x86)\\steam\\steam.exe";
				string arguments4 = "/C netsh advfirewall firewall add rule name=SteamB dir=out action=block program=" + text2 + " enable=yes";
				new Process
				{
					StartInfo = 
					{
						FileName = "cmd.exe",
						WindowStyle = ProcessWindowStyle.Hidden,
						Arguments = arguments4
					}
				}.Start();
				string arguments5 = "/C netsh advfirewall firewall add rule name=SteamB dir=in action=block program=" + text2 + " enable=yes";
				new Process
				{
					StartInfo = 
					{
						FileName = "cmd.exe",
						WindowStyle = ProcessWindowStyle.Hidden,
						Arguments = arguments5
					}
				}.Start();
				string arguments6 = "steam://rungameid/730";
				Process.Start(text2, arguments6);
			}
			else
			{
				Console.WriteLine("Selecte Steam.exe");
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Selecte Steam.exe";
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "Database files (*.exe)|*.exe;*";
				openFileDialog.FilterIndex = 0;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					string arguments7 = "/C netsh advfirewall firewall add rule name=SteamB dir=out action=block program=" + fileName + " enable=yes";
					new Process
					{
						StartInfo = 
						{
							FileName = "cmd.exe",
							WindowStyle = ProcessWindowStyle.Hidden,
							Arguments = arguments7
						}
					}.Start();
					string arguments8 = "/C netsh advfirewall firewall add rule name=SteamB dir=in action=block program=" + fileName + " enable=yes";
					new Process
					{
						StartInfo = 
						{
							FileName = "cmd.exe",
							WindowStyle = ProcessWindowStyle.Hidden,
							Arguments = arguments8
						}
					}.Start();
					string arguments9 = "steam://rungameid/730";
					Process.Start(fileName, arguments9);
				}
			}
		}
		else
		{
			string text3 = "C:\\Program Files\\steam\\steam.exe";
			string arguments10 = "/C netsh advfirewall firewall add rule name=SteamB dir=out action=block program=" + text3 + " enable=yes";
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					WindowStyle = ProcessWindowStyle.Hidden,
					Arguments = arguments10
				}
			}.Start();
			string arguments11 = "/C netsh advfirewall firewall add rule name=SteamB dir=in action=block program=" + text3 + " enable=yes";
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					WindowStyle = ProcessWindowStyle.Hidden,
					Arguments = arguments11
				}
			}.Start();
			string arguments12 = "steam://rungameid/730";
			Process.Start(text3, arguments12);
		}
		Thread.Sleep(500);
		Process[] processesByName4 = Process.GetProcessesByName("steam");
		for (int l = 0; l < processesByName4.Length; l++)
		{
			string path = "Damascus.dll";
			File.WriteAllBytes(path, Class6.Byte_0);
			string processName = "steam";
			Process process4 = Process.GetProcessesByName(processName).FirstOrDefault<Process>();
			if (process4 == null)
			{
				break;
			}
			string path2 = "Damascus.dll";
			if (!File.Exists(path2))
			{
				break;
			}
			byte[] byte_ = File.ReadAllBytes(path);
			Class8 @class = new Class8(process4)
			{
				Boolean_0 = true
			};
			Console.WriteLine(string.Format("{0:x8}", @class.method_23(byte_).ToInt64()));
			string arguments13 = "/C netsh advfirewall firewall delete rule name=SteamB";
			Process.Start("CMD.exe", arguments13);
			Thread.Sleep(500);
			if (File.Exists("Damascus.dll"))
			{
				File.Delete("Damascus.dll");
			}
		}
	}
}
