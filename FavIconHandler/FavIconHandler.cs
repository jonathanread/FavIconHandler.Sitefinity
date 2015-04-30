using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.Libraries;

namespace FavIconHandler.Sitefinity
{
	public static class FavIconHandler
	{
		public static string GetCurrentSiteFav(){

			var provider = LibrariesManager.GetManager().Provider.Name;
			LibrariesManager librariesManager = LibrariesManager.GetManager(provider);
			Telerik.Sitefinity.Libraries.Model.Image img = new Telerik.Sitefinity.Libraries.Model.Image();
			img = librariesManager.GetImages().Where(i => i.Extension == ".ico" && i.Title.ToString().ToLower() == "favicon" && i.Status == ContentLifecycleStatus.Live && i.Visible).FirstOrDefault();
			string url = "/favicon.ico";
			if (img != null)
			{
				url = img.MediaUrl;
			}
			else
			{
				img = librariesManager.GetImages().Where(i => i.Title.ToString().ToLower() == "favicon" && i.Status == ContentLifecycleStatus.Live && i.Visible).FirstOrDefault();
				if (img != null)
				{
					url = img.MediaUrl;
				}
			}
			return url;
		}
	}
}
