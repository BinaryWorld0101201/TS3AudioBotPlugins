using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using TS3AudioBot;
using TS3AudioBot.CommandSystem;
using TS3AudioBot.Helper;
using TS3AudioBot.Plugins;
using TS3Client.Commands;
using TS3Client.Full;
using TS3Client.Messages;
using TS3AudioBot.Config;
using System.Text;

namespace DropSystems
{
	public class Utils
	{
	}
	public static class PluginInfo
	{
		public static readonly string ShortName;
		public static readonly string Name;
		public static readonly string Description;
		public static readonly string Url;
		public static readonly string Author = "Bluscream";
		public static readonly Version Version = System.Reflection.Assembly.GetCallingAssembly().GetName().Version;
		static PluginInfo()
		{
			ShortName = typeof(PluginInfo).Namespace;
			var name = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
			Name = string.IsNullOrEmpty(name) ? ShortName : name;
		}
	}
	public class DropSystems : IBotPlugin
	{
		private static NLog.Logger Log = NLog.LogManager.GetLogger($"TS3AudioBot.Plugins.{PluginInfo.ShortName}");

		public Ts3FullClient Ts3FullClient { get; set; }
		public Ts3Client Ts3Client { get; set; }
		public Bot Bot { get; set; }
		public TickWorker Timer { get; set; }
		public ConfRoot ConfRoot { get; set; }


		/* [URL=client://12/1pvCr4o4ME05vJ/wnByqETm1rc4=~%C2%BB%20DropVerify]» DropVerify[/URL]

Willkommen » Verifizierung

Damit Sie unseren TeamSpeak umfangreich nutzen können, müssen Sie sich Verifizieren.
Hierfür gibt es bei uns zwei Möglichkeiten: Sie können entweder diesen Bot mit !verify anschreiben oder in Minecraft /verify eingeben.
Die beiden Variationen geben Ihnen zwar unterschiedliche Ränge, diese haben aber die gleichen Features.

Wir wünschen Ihnen noch einen schönen Aufenthalt auf unseren Netzwerken!




		*/

		public DropSystems() { }

		public void Initialize()
		{
			// Ts3FullClient.OnEachComplainList += OnComplainList;
			Log.Info("Plugin {0} v{1} by {2} loaded.", PluginInfo.Name, PluginInfo.Version, PluginInfo.Author);
		}

		public void Dispose()
		{
			// Ts3FullClient.OnEachComplainList -= OnComplainList;
			Log.Info("Plugin {} unloaded.", PluginInfo.Name);
		}
	}
}